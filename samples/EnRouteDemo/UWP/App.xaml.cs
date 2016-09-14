using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Networking.PushNotifications;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Core;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace EnRouteDemo.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        private static PushNotificationChannel _channel;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected async override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if ( System.Diagnostics.Debugger.IsAttached )
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif
            Frame rootFrame = Window.Current.Content as Frame;

            // Listen for the Activated event because we may have to turn on extended execution for location when that occurs
            Window.Current.CoreWindow.Activated -= CoreWindow_OnActivated;
            Window.Current.CoreWindow.Activated += CoreWindow_OnActivated;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if ( null == rootFrame )
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                Xamarin.Forms.Forms.Init(e);

                if ( ApplicationExecutionState.Terminated == e.PreviousExecutionState )
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if ( !e.PrelaunchActivated )
            {
                if ( null == rootFrame.Content )
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }

            await BackgroundExecutionManager.RequestAccessAsync();

            RegisterBackgroundTasks();

            await InitNotificationsAsync();
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        private void CoreWindow_OnActivated(CoreWindow sender, WindowActivatedEventArgs args)
        {
            // This seems to be the last chance we get to enable extended execution when going to the background.
            // Trying this on OnVisibilityChanged, OnEnteredBackground, or OnSuspending is too late.
            if ( (null != args) && (CoreWindowActivationState.Deactivated == args.WindowActivationState) )
            {
                ExtendedExecutionManager.Instance.BeginExtendedExecutionIfNeeded();
            }
        }

        protected override void OnBackgroundActivated(BackgroundActivatedEventArgs args)
        {
            base.OnBackgroundActivated(args);
            
            if ( args.TaskInstance.Task.Name == "PushBackgroundTask" )
            {
                try
                {
                    //TODO we probably need more time to handle this event
                    RawNotification notification = (RawNotification)args.TaskInstance.TriggerDetails;
                    EnRouteManagerWrapper.Instance.Manager.handleRemoteNotification(notification.Content);
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        private void RegisterBackgroundTasks()
        {
            // Check to make sure our task isn't already registered
            var taskRegistered = false;
            var pushTaskName = "PushBackgroundTask";
            foreach (var task in BackgroundTaskRegistration.AllTasks)
            {
                if ( task.Value.Name == pushTaskName )
                {
                    taskRegistered = true;
                    break;
                }
            }

            if ( !taskRegistered )
            {
                var builder = new BackgroundTaskBuilder();
                builder.Name = pushTaskName;
                builder.SetTrigger(new PushNotificationTrigger());
                BackgroundTaskRegistration task = builder.Register();
            }
        }

        private async Task InitNotificationsAsync()
        {
            try
            {
                // Create a channel for push notifications
                _channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();

                if ( EnRouteManagerWrapper.Instance.Manager.isStarted() )
                {
                    // If Glympse has been started we can register the token right away
                    EnRouteManagerWrapper.Instance.Manager.registerDeviceToken("wns", _channel.Uri);
                }
                else
                {
                    // Otherwise let's listen for when EnRoute has started
                    EnRouteManagerWrapper.Instance.Manager.addListener(new PlatformStartedListener());
                }

                // Register our event handler
                _channel.PushNotificationReceived += OnPushNotification;
            }
            catch (Exception e)
            {
                // An exception can occur if we try to get a channel with no data connection
            }
        }

        private void OnPushNotification(PushNotificationChannel sender, PushNotificationReceivedEventArgs e)
        {
            // Show a toast when a push is received for easy debugging
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);

            XmlNodeList elements = toastXml.GetElementsByTagName("text");
            foreach ( IXmlNode node in elements )
            {
                node.InnerText = "OnPushNotification";
            }

            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);

            String content = String.Empty;

            switch (e.NotificationType)
            {
                case PushNotificationType.Badge:
                    content = e.BadgeNotification.Content.GetXml();
                    break;
                case PushNotificationType.Tile:
                    content = e.TileNotification.Content.GetXml();
                    break;
                case PushNotificationType.Toast:
                    content = e.ToastNotification.Content.GetXml();
                    break;
                case PushNotificationType.Raw:
                    content = e.RawNotification.Content;
                    break;
            }

            // We'll handle the notification ourselves
            e.Cancel = true;

            // Forward the content to the Glympse EnRoute platform
            EnRouteManagerWrapper.Instance.Manager.handleRemoteNotification(content);
        }

        public class PlatformStartedListener : Glympse.Toolbox.GListener
        {
            public void eventsOccurred(Glympse.Toolbox.GSource source, int listener, int events, object param1, object param2)
            {
                if (Glympse.EnRoute.EnRouteEvents.LISTENER_ENROUTE_MANAGER == listener)
                {
                    if ( 0 == (events & Glympse.EnRoute.EnRouteEvents.ENROUTE_MANAGER_LOGIN_COMPLETED) )
                    {
                        EnRouteManagerWrapper.Instance.Manager.registerDeviceToken("wns", _channel.Uri);
                        EnRouteManagerWrapper.Instance.Manager.removeListener(this);
                    }
                }
            }
        }
    }
}

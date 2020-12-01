using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

using Foundation;
using UIKit;

using Glympse;
using Glympse.EnRoute;
using Glympse.EnRoute.iOS;

namespace EnRouteDemo.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public const bool IS_ENROUTE_MODE = true;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init ();

            if (IS_ENROUTE_MODE)
            {
                GEnRouteFactory enRouteFactory = new EnRouteFactory();
                LoadApplication(new App(enRouteFactory));

                // Register for a Push notification token
                if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
                {
                    var pushSettings = UIUserNotificationSettings.GetSettingsForTypes(
                                       UIUserNotificationType.Alert | UIUserNotificationType.Badge |
                                       UIUserNotificationType.Sound,
                                       new NSSet());

                    UIApplication.SharedApplication.RegisterUserNotificationSettings(pushSettings);
                    UIApplication.SharedApplication.RegisterForRemoteNotifications();
                }
                else
                {
                    UIRemoteNotificationType notificationTypes = UIRemoteNotificationType.Alert |
                    UIRemoteNotificationType.Badge | UIRemoteNotificationType.Sound;
                    UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(notificationTypes);
                }
            }
            else
            {
                GGlympseFactory glympseFactory = new GlympseFactory();
                LoadApplication(new App(glympseFactory));
            }

            return base.FinishedLaunching (app, options);
        }
        
        public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
        {
            // Get current device token
            byte[] bytes = deviceToken.ToArray<byte>();
            string[] hexArray = bytes.Select(b => b.ToString("x2")).ToArray();
            var DeviceToken = string.Join(string.Empty, hexArray);

            Debug.WriteLine(DeviceToken);

            // Get previous device token
            var oldDeviceToken = NSUserDefaults.StandardUserDefaults.StringForKey("PushDeviceToken");

            // Has the token changed?
            if (string.IsNullOrEmpty(oldDeviceToken) || !oldDeviceToken.Equals(DeviceToken))
            {
                Debug.WriteLine("Sharing device token with EnRoute platform");
                if (IS_ENROUTE_MODE)
                {
                    EnRouteManagerWrapper.Instance.Manager.registerDeviceToken("apple_background", DeviceToken);
                }
            }

            // Save new device token 
            NSUserDefaults.StandardUserDefaults.SetString(DeviceToken, "PushDeviceToken");
        }
        
        public override void FailedToRegisterForRemoteNotifications (UIApplication application , NSError error)
        {
            Debug.WriteLine("FailedToRegisterForRemoteNotifications()");
        }
        
        public override void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
        {
            Debug.WriteLine("ReceivedRemoteNotification:" + userInfo.Description);
            if (IS_ENROUTE_MODE)
            {
                EnRouteManagerWrapper.Instance.Manager.handleRemoteNotification(userInfo.Description);
            }
        }
        
        public override void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, 
            Action<UIBackgroundFetchResult> completionHandler)
        {
            Debug.WriteLine("DidReceiveRemoteNotification:" + userInfo.Description);
            if (IS_ENROUTE_MODE)
            {
                EnRouteManagerWrapper.Instance.Manager.handleRemoteNotification(userInfo.Description);
            }
            completionHandler(UIBackgroundFetchResult.NewData);
        }
    }
}

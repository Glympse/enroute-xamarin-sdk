using System;

using Xamarin.Forms;

using Glympse;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    public class App : Application
    {
        GEnRouteFactory _enRouteFactory;

        public App(GEnRouteFactory enRouteFactory)
        {
            _enRouteFactory = enRouteFactory;
            EnRouteManagerWrapper.Instance.create(enRouteFactory);

            Button loginButton = new Button
            {
                Text = "Login",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            loginButton.Clicked += onLoginClicked;

            Button logoutButton = new Button
            {
                Text = "Logout",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            logoutButton.Clicked += onLogoutClicked;

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        loginButton,
                        logoutButton
                    }
                }
            };

            Auth.onAppStart(EnRouteManagerWrapper.Instance.Manager);
        }

        void onLoginClicked(object sender, EventArgs e)
        {
            EnRouteManagerWrapper.Instance.clear();
            EnRouteManagerWrapper.Instance.create(_enRouteFactory);
            Auth.onAppStart(EnRouteManagerWrapper.Instance.Manager);
        }

        void onLogoutClicked(object sender, EventArgs e)
        {
            Auth.onDriverLogout(EnRouteManagerWrapper.Instance.Manager);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}


using System;

using Xamarin.Forms;

using Glympse;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    public class App : Application
    {
        private GEnRouteFactory _enRouteFactory;

        private GEnRouteManager _enRouteManager;

        public App (GEnRouteFactory enRouteFactory)
        {
            _enRouteFactory = enRouteFactory;

            _enRouteManager = _enRouteFactory.createEnRouteManager();

            // The root page of your application
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }            
    }
}


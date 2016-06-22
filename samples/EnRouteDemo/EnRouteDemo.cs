using System;

using Xamarin.Forms;

using Glympse;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    public class App : Application
    {
        public App (GEnRouteFactory enRouteFactory)
        {
            EnRouteManagerWrapper.Instance.create(enRouteFactory);
            
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
            
            Auth.onAppStart(EnRouteManagerWrapper.Instance.Manager);
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


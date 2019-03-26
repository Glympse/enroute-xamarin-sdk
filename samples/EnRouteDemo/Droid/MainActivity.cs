using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Glympse;
using Glympse.EnRoute;
using Glympse.EnRoute.Android;

namespace EnRouteDemo.Droid
{
    [Activity (Label = "EnRouteDemo.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        public const bool IS_ENROUTE_MODE = true;

        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            global::Xamarin.Forms.Forms.Init (this, bundle);

            if (IS_ENROUTE_MODE)
            {
                GEnRouteFactory enRouteFactory = new EnRouteFactory(Application.Context);
                LoadApplication(new App(enRouteFactory));
            }
            else
            {
                GGlympseFactory glympseFactory = new GlympseFactory(Application.Context);
                LoadApplication(new App(glympseFactory));
            }
        }
    }
}


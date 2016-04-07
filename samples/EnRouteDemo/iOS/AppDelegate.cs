using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Glympse.EnRoute;
using Glympse.EnRoute.iOS;

namespace EnRouteDemo.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init ();

            GEnRouteFactory enRouteFactory = new EnRouteFactory();

            LoadApplication (new App (enRouteFactory));

            return base.FinishedLaunching (app, options);
        }
    }
}


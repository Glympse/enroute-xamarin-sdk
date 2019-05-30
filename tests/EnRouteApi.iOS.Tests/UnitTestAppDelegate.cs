using System.IO;

using Foundation;
using UIKit;
using NUnit.Runner.Services;

namespace EnRouteApi.iOS.Tests
{
    [Register("UnitTestAppDelegate")]
    public partial class UnitTestAppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            // This will load all tests within the current project
            var nunit = new NUnit.Runner.App();

            nunit.Options = new TestOptions
            {
                AutoRun = true,
                CreateXmlResultFile = true,
                ResultFilePath = Path.Combine(NSFileManager.DefaultManager.GetUrls(NSSearchPathDirectory.LibraryDirectory, NSSearchPathDomain.User)[0].Path, "Results.xml")
            };

            LoadApplication(nunit);

            return base.FinishedLaunching(app, options);
        }
    }
}

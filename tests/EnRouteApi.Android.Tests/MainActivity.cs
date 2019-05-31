using System.IO;
using System.Reflection;

using Android.App;
using Android.Content.PM;
using Android.OS;
using NUnit.Runner.Services;

namespace EnRouteApi.Android.Tests
{
    [Activity(Label = "NUnit 3", MainLauncher = true, Theme = "@android:style/Theme.Holo.Light", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var nunit = new NUnit.Runner.App();

            nunit.Options = new TestOptions
            {
                AutoRun = true,
                CreateXmlResultFile = true,
                ResultFilePath = Path.Combine(Environment.ExternalStorageDirectory.Path, Environment.DirectoryDownloads, "Nunit", "Results.xml")
            };

            LoadApplication(nunit);
        }
    }
}

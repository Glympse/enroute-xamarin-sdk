using System.Reflection;

using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;

namespace EnRouteApi.Android.Tests
{
    [Activity(Label = "EnRouteApi.Android.Tests", MainLauncher = true)]
    public class MainActivity : TestSuiteActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Intent.PutExtra("automated", true);
            AddTest(Assembly.GetExecutingAssembly());
            base.OnCreate(bundle);
        }
    }
}

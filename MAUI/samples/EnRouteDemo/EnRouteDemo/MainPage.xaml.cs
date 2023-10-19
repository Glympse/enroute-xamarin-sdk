using Glympse.EnRoute;
#if ANDROID
using Glympse.EnRoute.Android;
using Microsoft.Maui.Controls.PlatformConfiguration;
#elif iOS
using Glympse.EnRoute.iOS;
#endif

namespace EnRouteDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

#if ANDROID
		GEnRouteFactory enRouteFactory = new EnRouteFactory(Platform.AppContext);
#elif IOS
		GEnRouteFactory enRouteFactory = new Glympse.EnRoute.iOS.EnRouteFactory();
#endif

        EnRouteManagerWrapper.Instance.Initialize(enRouteFactory);
        Auth.onAppStart(EnRouteManagerWrapper.Instance.Manager);
    }

    private void OnLoginClicked(object sender, EventArgs e)
	{
        if ( EnRouteManagerWrapper.Instance.Manager.isLoginNeeded() )
		{
            Auth.start(EnRouteManagerWrapper.Instance.Manager);
        }
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        if (!EnRouteManagerWrapper.Instance.Manager.isLoginNeeded())
        {
            EnRouteManagerWrapper.Instance.Manager.logout(EnRouteConstants.LOGOUT_REASON_USER_ACTION);
        }
    }
}



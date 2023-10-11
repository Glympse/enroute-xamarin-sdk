using Glympse.EnRoute;
#if ANDROID
using Glympse.EnRoute.Android;
#elif iOS
using Glympse.EnRoute.iOS;
#endif

namespace EnRouteDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

#if ANDROID
		GEnRouteFactory enRouteFactory = new EnRouteFactory(Platform.AppContext);
#elif IOS
		GEnRouteFactory enRouteFactory = null;
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



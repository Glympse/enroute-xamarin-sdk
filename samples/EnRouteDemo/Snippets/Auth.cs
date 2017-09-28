using System;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    /**
     * Demonstrates the use of basic authentication. 
     */ 
    public class Auth
    {
        private static EnRouteDemo.Listener _listener;

        private static String _driverEmail = "adam-test@marken.com";
        private static String _driverPassword = "ah";

        public static void onAppStart(GEnRouteManager manager)
        {
            _listener = new EnRouteDemo.Listener();
            manager.addListener(_listener);
            manager.setAuthenticationMode(EnRouteConstants.AUTH_MODE_CREDENTIALS);
            manager.start();
        }

        public static void onDriverLogout(GEnRouteManager manager)
        {
            manager.logout(EnRouteConstants.LOGOUT_REASON_USER_ACTION);
        }

        public static void login(GEnRouteManager manager)
        {
            manager.loginWithCredentials(_driverEmail, _driverPassword);
            //manager.loginWithToken("gaFmAA.WWqOwtHJ}Ac16TfbBh-vW9Gc0KDDUlCKoqTC-JdTMY0xG}zCK3/Zb4ySbYR{zOnGu9yMsCsPLXymElcao3ECQRzhhRDppws19OVr8LQQyjeNqOaGBh61H2WB6ARU-6Cn", 1606528270000);
        }
    }
}


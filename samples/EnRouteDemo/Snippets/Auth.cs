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

        private static String _driverEmail = "<< Driver Email >>";
        private static String _driverPassword = "<< Driver Password >>";

        public static void onAppStart(GEnRouteManager manager)
        {
            Auth.start(manager);
        }

        public static void start(GEnRouteManager manager)
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
        }
    }
}


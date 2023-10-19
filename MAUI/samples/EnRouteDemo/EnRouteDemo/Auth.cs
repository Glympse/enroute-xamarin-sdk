using Glympse.EnRoute;

namespace EnRouteDemo
{
    /**
     * Demonstrates the use of basic authentication. 
     */
    public class Auth
    {
        private static Listener _listener;

        private static String _driverEmail = "<< Driver Email >>";
        private static String _driverPassword = "<< Driver Password >>";

        public static void onAppStart(GEnRouteManager manager)
        {
            Auth.start(manager);
        }

        public static void start(GEnRouteManager manager)
        {
            _listener = new Listener();
            manager.overrideLoggingLevels(1, 1); // Used for increased logging during development or debugging
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
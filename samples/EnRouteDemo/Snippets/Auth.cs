using System;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    /**
     * Demonstrates the use of basic authentication. 
     */ 
    public class Auth
    {
        private static String _driverEmail = "<< Driver Email >>";
        private static String _driverPassword = "<< Driver Password >>";

        public static void onAppStart(GEnRouteManager manager)
        {
            // Create a listener that subscribes to events from the manager.
            // The listener will be notified if a login is necessary.
            Listener listener = new Listener();
            listener.subscribe(manager);

            // Start the manager
            manager.start();
        }

        public static void onDriverLogout(GEnRouteManager manager)
        {
            manager.logout(EnRouteConstants.LOGOUT_REASON_USER_ACTION);
        }

        public static void onLoginRequired()
        {
            // Note: The preferred method of refreshing the token is to perform server to server
            // authentication to get a fresh token. Now would be the correct time to request
            // that token and then call:
            // manager.login(token, expiresIn);

            // In this case we are using username and password for login. 
            GEnRouteManager manager = EnRouteManagerWrapper.Instance.Manager;
            manager.login(_driverEmail, _driverPassword);
        }
    }
}


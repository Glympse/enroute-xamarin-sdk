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
            if ( manager.isLoginNeeded() ) 
            {
                manager.login(_driverEmail, _driverPassword);
            } 
            else 
            {
                manager.start();
            }
        }

        public static void onDriverLogout(GEnRouteManager manager)
        {
            manager.logout(EnRouteConstants.LOGOUT_REASON_USER_ACTION);
        }
    }
}


using System;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    /**
     * Demonstrates the use of event subscription model.
     * 
     * Notes:
     * - It is important that applicaiton unregisteres all unused listeners. 
     *   Failure to do so may result in performance degradation and memory leakage. 
     */ 
    public class Listener : GListener
    {
        public void subscribe(GEnRouteManager manager)
        {
            manager.addListener(this);
        }

        public void unsubscribe(GEnRouteManager manager)
        {
            manager.removeListener(this);
        }

        public void eventsOccurred(GSource source, int listener, int events, object param1, object param2)
        {     
            if ( EnRouteEvents.LISTENER_ENROUTE_MANAGER == listener ) 
            {
                if ( 0 != (EnRouteEvents.ENROUTE_MANAGER_LOGIN_REQUIRED & events) )
                {
                    // EnRouteManager lets us know when a login is required due to token expiration.
                    Auth.onLoginRequired();
                }
                if ( 0 != (EnRouteEvents.ENROUTE_MANAGER_LOGIN_COMPLETED & events) )
                {
                    // Logged in!
                }
                if ( 0 != (EnRouteEvents.ENROUTE_MANAGER_LOGGED_OUT & events) )
                {
                    // Logged out!
                }
            }
        }
    }
}
    
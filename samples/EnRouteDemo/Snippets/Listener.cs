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
            System.Diagnostics.Debug.WriteLine("listener: " + listener + ", events: " + events);
            if ( EnRouteEvents.LISTENER_ENROUTE_MANAGER == listener ) 
            {
                if (0 != (EnRouteEvents.ENROUTE_MANAGER_STARTED & events))
                {
					// Started
                    System.Diagnostics.Debug.WriteLine("EnRouteManager started");
                }
                if (0 != (EnRouteEvents.ENROUTE_MANAGER_AUTHENTICATION_NEEDED & events))
                {
                    // Auth Needed
                    System.Diagnostics.Debug.WriteLine("Login required. Doing login");
                    Auth.login(EnRouteManagerWrapper.Instance.Manager);
                }
                if ( 0 != (EnRouteEvents.ENROUTE_MANAGER_SYNCED & events) )
                {
                    // Synced
                    System.Diagnostics.Debug.WriteLine("EnRouteManager synced");
                }
                if ( 0 != (EnRouteEvents.ENROUTE_MANAGER_LOGGED_OUT & events) )
                {
                    long reason = (long)param1;
                    // Logged out!
                    System.Diagnostics.Debug.WriteLine("EnRouteManager Logged out");
                }
            }
        }
    }
}
    
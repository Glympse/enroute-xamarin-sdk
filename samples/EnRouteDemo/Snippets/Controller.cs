using System;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    /**
     * Demonstrates the use of EnRouteManager in one of application controllers. 
     * 
     * Notes:
     * - It is of prime importance to notfify EnRoute SDK when applicaiton transitions
     *   between foreground and background states. 
     */
    public class Controller
    {
        private GEnRouteManager _manager;

        public Controller(GEnRouteManager manager)
        {
            _manager = manager;
        }

        public void onResume()
        {
            _manager.setActive(true);
        }

        public void onPause()
        {
            _manager.setActive(false);
        }
    }
}


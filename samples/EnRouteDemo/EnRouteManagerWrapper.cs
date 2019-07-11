using System;

using Glympse;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    public class EnRouteManagerWrapper : GListener
    {
        private static EnRouteManagerWrapper instance;

        private GEnRouteFactory _enRouteFactory;
        private GEnRouteManager _enRouteManager;
        private bool _stopped;

        private EnRouteManagerWrapper()
        {
        }

        public static EnRouteManagerWrapper Instance
        {
            get 
            {
                if ( null == instance ) 
                {
                    instance = new EnRouteManagerWrapper();
                }
                return instance;
            }
        }

        public void Initialize(GEnRouteFactory enRouteFactory)
        {
            _enRouteFactory = enRouteFactory;
        }

        public GEnRouteManager Manager
        {
            get 
            {
                if ( null == _enRouteFactory )
                {
                    throw new Exception("EnRouteManagerWrapper.Initialize(...) must be called once before accessing the Manager property");
                }

                if ( _stopped || null == _enRouteManager ) 
                {
                    createManager();
                    _stopped = false;
                }

                return _enRouteManager;
            }
        }

        private void createManager()
        {
        	_enRouteManager = _enRouteFactory.createEnRouteManager();
            _enRouteManager.overrideLoggingLevels(1, 1);
            _enRouteManager.addListener(this);
        }

        public void eventsOccurred(GSource source, int listener, int events, object param1, object param2)
        {
            if (EnRouteEvents.LISTENER_ENROUTE_MANAGER == listener)
            {
                if (0 != (EnRouteEvents.ENROUTE_MANAGER_STOPPED & events))
                {
                    // Manager is stopped and can not be used again.
                    _enRouteManager.removeListener(this);
                    _enRouteManager = null;
                    _stopped = true;
                }
            }
        }
    }
}
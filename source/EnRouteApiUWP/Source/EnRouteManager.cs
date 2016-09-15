extern alias EnRouteApiDll;
extern alias GlympseApiToolboxDll;

using Glympse.Toolbox;

namespace Glympse.EnRoute.UWP
{
    public class EnRouteManager : GEnRouteManager
    {
        private EnRouteApiDll::Glympse.EnRoute.GEnRouteManager _raw;

        private CommonSource _source;

        public EnRouteManager(EnRouteApiDll::Glympse.EnRoute.GEnRouteManager raw)
        {
            _raw = raw;
            _source = new CommonSource(_raw);
        }

        /**
         * GEnRouteManager section
         */ 

        public bool isLoginNeeded()
        {
            return _raw.isLoginNeeded();
        }

        public bool login(string username, string password)
        {
            return _raw.login(username, password);
        }

        public void logout(int reason)
        {
            _raw.logout(reason);
        }

        public bool start()
        {
            return _raw.start();
        }

        public void stop()
        {
            _raw.stop();
        }           
            
        public bool isStarted()
        {
            return _raw.isStarted();
        }

        public void setActive(bool active)
        {
            _raw.setActive(active);
        }

        public bool isActive()
        {
            return _raw.isActive();
        }

        public void refresh()
        {
            _raw.refresh();
        }

        public GOrganization getOrganization()
        {
            return (GOrganization)ClassBinder.bind(_raw.getOrganization());
        }

        public GAgent getLoggedInAgent()
        {
            return (GAgent)ClassBinder.bind(_raw.getLoggedInAgent());
        }

        public string getEnRouteToken()
        {
            return _raw.getEnRouteToken();
        }

        public GTaskManager getTaskManager()
        {
            return (GTaskManager)ClassBinder.bind(_raw.getTaskManager());
        }
        
        public void handleRemoteNotification(string payload)
        {
            _raw.handleRemoteNotification(payload);
        }
        
        public void registerDeviceToken(string tokenType, string deviceToken)
        {
            _raw.registerDeviceToken(tokenType, deviceToken);
        }

        /**
         * GSource section
         */

        public bool addListener(GListener listener)
        {
            return _source.addListener(listener);

        }            

        public bool removeListener(GListener listener)
        {
            return _source.removeListener(listener);
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}


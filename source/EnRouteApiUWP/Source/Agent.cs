extern alias EnRouteApiDll;

namespace Glympse.EnRoute.UWP
{
    class Agent : GAgent
    {
        private EnRouteApiDll::Glympse.EnRoute.GAgent _raw;

        public Agent(EnRouteApiDll::Glympse.EnRoute.GAgent raw)
        {
            _raw = raw;
        }

        public long getId()
        {
            return _raw.getId();
        }

        public string getName()
        {
            return _raw.getName();
        }

        public string getEmail()
        {
            return _raw.getEmail();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

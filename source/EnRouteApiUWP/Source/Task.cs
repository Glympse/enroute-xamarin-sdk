extern alias EnRouteApiDll;

namespace Glympse.EnRoute.UWP
{
    class Task : GTask
    {
        private EnRouteApiDll::Glympse.EnRoute.GTask _raw;

        public Task(EnRouteApiDll::Glympse.EnRoute.GTask raw)
        {
            _raw = raw;
        }

        public int getState()
        {
            return _raw.getState();
        }

        public long getId()
        {
            return _raw.getId();
        }

        public GOperation getOperation()
        {
            return (GOperation)ClassBinder.bind(_raw.getOperation());
        }

        public string getDescription()
        {
            return _raw.getDescription();
        }

        public long getDueTime()
        {
            return _raw.getDueTime();
        }

        public string getPhase()
        {
            return _raw.getPhase();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

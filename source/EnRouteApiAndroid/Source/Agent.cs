using System;

namespace Glympse.EnRoute.Android
{
    class Agent : GAgent
    {
        private com.glympse.enroute.android.api.GAgent _raw;

        public Agent(com.glympse.enroute.android.api.GAgent raw)
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

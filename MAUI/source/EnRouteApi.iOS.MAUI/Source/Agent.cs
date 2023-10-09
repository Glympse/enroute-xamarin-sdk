using System;

namespace Glympse.EnRoute.iOS
{
    class Agent : GAgent
    {
        private GlyAgent _raw;

        public Agent(GlyAgent raw)
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

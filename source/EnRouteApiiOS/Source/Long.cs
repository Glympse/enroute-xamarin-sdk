using System;

namespace Glympse.EnRoute.iOS
{
    class Long : GLong
    {
        private GlyLong _raw;

        public Long(GlyLong raw)
        {
            _raw = raw;
        }

        public object raw()
        {
            return _raw;
        }

        public long longValue()
        {
            return _raw.longValue();
        }
    }
}

extern alias GlympseApiDll;

namespace Glympse.EnRoute.UWP
{
    class Long : GLong
    {
        private GlympseApiDll::Glympse.GLong _raw;

        public Long(GlympseApiDll::Glympse.GLong raw)
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

using System;

namespace Glympse.EnRoute.Android
{
    class Place : GPlace
    {
        private com.glympse.android.api.GPlace _raw;

        public Place(com.glympse.android.api.GPlace raw)
        {
            _raw = raw;
        }

        public object raw()
        {
            return _raw;
        }

        public string getName()
        {
            return _raw.getName();
        }

        public double getLatitude()
        {
            return _raw.getLatitude();
        }

        public double getLongitude()
        {
            return _raw.getLongitude();
        }
    }
}

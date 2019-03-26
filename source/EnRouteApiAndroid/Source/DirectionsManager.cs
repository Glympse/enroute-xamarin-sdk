using System;

namespace Glympse.EnRoute.Android
{
    class DirectionsManager : GDirectionsManager
    {
        private com.glympse.android.api.GDirectionsManager _raw;

        public DirectionsManager(com.glympse.android.api.GDirectionsManager raw)
        {
            _raw = raw;
        }

        public void setTravelMode(int mode)
        {
            _raw.setTravelMode(mode);
        }

        public object raw()
        {
            return _raw;
        }
    }
}

using System;

namespace Glympse.EnRoute.iOS
{
    class DirectionsManager : GDirectionsManager
    {
        private GlyDirectionsManager _raw;

        public DirectionsManager(GlyDirectionsManager raw)
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

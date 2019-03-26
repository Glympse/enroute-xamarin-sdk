using System;

namespace Glympse.EnRoute.iOS
{
    class Place : GPlace
    {
        private GlyPlace _raw;

        public Place(GlyPlace raw)
        {
            _raw = raw;
        }

        public object raw()
        {
            return _raw;
        }
    }
}

using System;

namespace Glympse.EnRoute.Android
{
    class Track : GTrack
    {
        private com.glympse.android.api.GTrack _raw;

        public Track(com.glympse.android.api.GTrack raw)
        {
            _raw = raw;
        }

        /**
         * GTrack section
         */
        public int length()
        {
            return _raw.length();
        }

        public int getDistance()
        {
            return _raw.getDistance();
        }

        public GList<GLocation> getLocations()
        {
            return new List<GLocation>(_raw.getLocations());
        }

        public GList<GLocation> getNewLocations()
        {
            return new List<GLocation>(_raw.getNewLocations());
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}

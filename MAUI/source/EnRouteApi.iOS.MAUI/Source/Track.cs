using System;

namespace Glympse.EnRoute.iOS
{
    class Track : GTrack
    {
        private GlyTrack _raw;

        public Track(GlyTrack raw)
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

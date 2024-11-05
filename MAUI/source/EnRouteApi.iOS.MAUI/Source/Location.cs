namespace Glympse.EnRoute.iOS
{
    class Location : GLocation
    {
        private GlyLocation _raw;

        public Location(GlyLocation raw)
        {
            _raw = raw;
        }

        public double getLatitude()
        {
            return _raw.getLatitude();
        }

        public double getLongitude()
        {
            return _raw.getLongitude();
        }

        public long getTime()
        {
          return _raw.getTime();
        }

        public float getVAccuracy()
        {
          return _raw.getVAccuracy();
        }

        public float getHAccuracy()
        {
          return _raw.getHAccuracy();
        }

        public float getSpeed()
        {
          return _raw.getSpeed();
        }

        public float getBearing()
        {
          return _raw.getBearing();
        }

        public float getAltitude()
        {
          return _raw.getAltitude();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

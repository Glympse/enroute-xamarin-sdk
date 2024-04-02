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

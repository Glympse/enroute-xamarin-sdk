namespace Glympse.EnRoute.iOS
{
    class PickupArrivalData : GPickupArrivalData
    {
        private GlyPickupArrivalData _raw;

        public PickupArrivalData(GlyPickupArrivalData raw)
        {
            _raw = raw;
        }

        /**
         * GPickupArrivalData section
         */

        public string getStallLabel()
        {
            return _raw.getStallLabel();
        }

        public string getCarColor()
        {
            return _raw.getCarColor();
        }

        public string getCarMake()
        {
            return _raw.getCarMake();
        }

        public string getCarModel()
        {
            return _raw.getCarModel();
        }

        public string getLicensePlate()
        {
            return _raw.getLicensePlate();
        }

        public bool isPickupInStore()
        {
            return _raw.isPickupInStore();
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

using System;

namespace Glympse.EnRoute.Android
{
    class PickupArrivalData : GPickupArrivalData
    {
        private com.glympse.android.api.GPickupArrivalData _raw;

        public PickupArrivalData(com.glympse.android.api.GPickupArrivalData raw)
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

        public string getLicensePlate()
        {
            return _raw.getLicensePlate();
        }

        public string getCarMake()
        {
            return _raw.getCarMake();
        }

        public string getCarModel()
        {
            return _raw.getCarModel();
        }

        public string getCarColor()
        {
            return _raw.getCarColor();
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

using System;

namespace Glympse.EnRoute.Android
{
    class PickupArrivalDataBuilder : GPickupArrivalDataBuilder
    {
        private com.glympse.android.api.GPickupArrivalDataBuilder _raw;

        public PickupArrivalDataBuilder(com.glympse.android.api.GPickupArrivalDataBuilder raw)
        {
            _raw = raw;
        }

        /**
         * GPickupArrivalDataBuilder section
         */

        public void setCarColor(string carColor)
        {
            _raw.setCarColor(carColor);
        }

        public void setCarMake(string carMake)
        {
            _raw.setCarMake(carMake);
        }

        public void setCarModel(string carModel)
        {
            _raw.setCarModel(carModel);
        }

        public void setLicensePlate(string licensePlate)
        {
            _raw.setLicensePlate(licensePlate);
        }

        public void setStallLabel(string stallLabel)
        {
            _raw.setStallLabel(stallLabel);
        }

        public void setPickupInStore(bool isPickupInStore)
        {
            _raw.setPickupInStore(isPickupInStore);
        }

        public GPickupArrivalData getPickupArrivalData()
        {
            return (GPickupArrivalData)ClassBinder.bind(_raw.getPickupArrivalData());
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

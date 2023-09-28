using System;

namespace Glympse.EnRoute.iOS
{
    class PickupArrivalDataBuilder : GPickupArrivalDataBuilder
    {
        private GlyPickupArrivalDataBuilder _raw;

        public PickupArrivalDataBuilder(GlyPickupArrivalDataBuilder raw)
        {
            _raw = raw;
        }

        /**
         * GPickupArrivalDataBuilder section
         */

        public void setStallLabel(string stallLabel)
        {
            _raw.setStallLabel(stallLabel);
        }

        public void setLicensePlate(string licensePlate)
        {
            _raw.setLicensePlate(licensePlate);
        }

        public void setCarMake(string carMake)
        {
            _raw.setCarMake(carMake);
        }

        public void setCarModel(string carModel)
        {
            _raw.setCarModel(carModel);
        }

        public void setCarColor(string carColor)
        {
            _raw.setCarColor(carColor);
        }

        public void setPickupInStore(bool isPickupInStore)
        {
            _raw.setPickupInStore(isPickupInStore);
        }

        public GPickupArrivalData getPickupArrivalData()
        {
            return (GPickupArrivalData)_raw.getPickupArrivalData();
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

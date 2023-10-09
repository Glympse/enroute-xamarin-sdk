using System;

namespace Glympse
{
    public interface GPickupArrivalData : GCommon
    {
        string getStallLabel();

        string getLicensePlate();

        string getCarMake();

        string getCarModel();

        string getCarColor();

        bool isPickupInStore();
    }
}

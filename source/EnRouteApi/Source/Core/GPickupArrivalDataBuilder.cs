namespace Glympse;

public interface GPickupArrivalDataBuilder : GCommon
{
    void setStallLabel(string stallLabel);

    void setLicensePlate(string licensePlate);

    void setCarMake(string carMake);

    void setCarModel(string carModel);

    void setCarColor(string carColor);

    void setPickupInStore(bool isPickupInStore);

    GPickupArrivalData getPickupArrivalData();
}
namespace Glympse.EnRoute.iOS;

internal class PickupArrivalData : GPickupArrivalData
{
    GlyPickupArrivalData _raw;

    public PickupArrivalData(GlyPickupArrivalData raw) =>
        _raw = raw;

    /**
     * GPickupArrivalData section
     */

    public string getStallLabel() =>
        _raw.getStallLabel();

    public string getCarColor() =>
        _raw.getCarColor();

    public string getCarMake() =>
        _raw.getCarMake();

    public string getCarModel() =>
        _raw.getCarModel();

    public string getLicensePlate() =>
        _raw.getLicensePlate();

    public bool isPickupInStore() =>
        _raw.isPickupInStore();

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}
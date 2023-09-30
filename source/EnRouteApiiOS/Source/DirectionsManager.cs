namespace Glympse.EnRoute.iOS;

internal class DirectionsManager : GDirectionsManager
{
    GlyDirectionsManager _raw;

    public DirectionsManager(GlyDirectionsManager raw) =>
        _raw = raw;

    public void setTravelMode(int mode)
    {
        _raw.setTravelMode(mode);
    }

    public object raw() =>
        _raw;
}
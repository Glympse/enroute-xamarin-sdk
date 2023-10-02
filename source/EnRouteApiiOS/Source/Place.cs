namespace Glympse.EnRoute.iOS;

internal class Place : GPlace
{
    GlyPlace _raw;

    public Place(GlyPlace raw) =>
        _raw = raw;

    public object raw() =>
        _raw;
}
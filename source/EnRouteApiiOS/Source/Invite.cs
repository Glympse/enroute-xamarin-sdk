namespace Glympse.EnRoute.iOS;

internal class Invite : GInvite
{
    GlyInvite _raw;

    public Invite(GlyInvite raw) =>
        _raw = raw;

    public string getAddress() =>
        _raw.getAddress();

    public int getType() =>
        _raw.getType();

    public object raw() =>
        _raw;
}
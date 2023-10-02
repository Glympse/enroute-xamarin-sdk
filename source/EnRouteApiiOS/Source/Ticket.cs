namespace Glympse.EnRoute.iOS;

internal class Ticket : GTicket
{
    GlyTicket _raw;

    public Ticket(GlyTicket raw) =>
        _raw = raw;

    public bool appendData(long partnerId, string name, GPrimitive value) =>
        _raw.appendData(partnerId, name, (GlyPrimitive)value.raw());

    public bool addInvite(GInvite invite) =>
        _raw.addInvite((GlyInvite)invite.raw());

    public bool expire() =>
        _raw.expire();

    public bool extend(long interval) =>
        _raw.extend(interval);

    public long getDuration() =>
        _raw.getDuration();

    public long getEta() =>
        _raw.getEta();

    public string getId() =>
        _raw.getId();

    public GArray<GInvite> getInvites() =>
        new Array<GInvite>(_raw.getInvites());

    public bool modify(long remaining, string message, GPlace destination) =>
        _raw.modify(remaining, message, (GlyPlace)destination.raw());

    public void updateEta(long eta)
    {
        _raw.updateEta(eta);
    }

    public object raw() =>
        _raw;
}
namespace Glympse.EnRoute.iOS;

internal class Operation : GOperation
{
    GlyOperation _raw;

    public Operation(GlyOperation raw) =>
        _raw = raw;

    public int getState() =>
        _raw.getState();

    public long getId() =>
        _raw.getId();

    public long getStartTime() =>
        _raw.getStartTime();

    public string getTicketId() =>
        _raw.getTicketId();

    public string getInviteUrl() =>
        _raw.getInviteUrl();

    public string getInviteCode() =>
        _raw.getInviteCode();

    public long getTaskId() =>
        _raw.getTaskId();

    public void setTicketEta(long eta)
    {
        _raw.setTicketEta(eta);
    }

    public void setTicketVisible(string visible)
    {
        _raw.setTicketVisible(visible);
    }

    public object raw() =>
        _raw;
}
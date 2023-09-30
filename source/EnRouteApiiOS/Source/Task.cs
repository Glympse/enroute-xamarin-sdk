namespace Glympse.EnRoute.iOS;

internal class Task : GTask
{
    GlyTask _raw;

    public Task(GlyTask raw) =>
        _raw = raw;

    public int getState() =>
        _raw.getState();

    public long getId() =>
        _raw.getId();

    public GOperation getOperation() =>
        (GOperation)ClassBinder.bind(_raw.getOperation());

    public string getDescription() =>
        _raw.getDescription();

    public long getDueTime() =>
        _raw.getDueTime();

    public string getPhase() =>
        _raw.getPhase();

    public string getForeignId() =>
        _raw.getForeignId();

    public string getChatRoomId() =>
        _raw.getChatRoomId();

    public object raw() =>
        _raw;
}
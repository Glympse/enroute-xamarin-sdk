namespace Glympse.EnRoute.iOS;

internal class Agent : GAgent
{
    GlyAgent _raw;

    public Agent(GlyAgent raw) =>
        _raw = raw;

    public long getId() =>
        _raw.getId();

    public string getName() =>
        _raw.getName();

    public string getEmail() =>
        _raw.getEmail();

    public object raw() =>
        _raw;
}

namespace Glympse.EnRoute.iOS;

internal class User : GUser
{
    GlyUser _raw;

    public User(GlyUser raw) =>
        _raw = raw;

    public bool setNickname(string nickname) =>
        _raw.setNickname(nickname);

    public string getNickname() =>
        _raw.getNickname();

    public object raw() =>
        _raw;
}
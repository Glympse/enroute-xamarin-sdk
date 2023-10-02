namespace Glympse.EnRoute.iOS;

internal class UserManager : GUserManager
{
    GlyUserManager _raw;

    public UserManager(GlyUserManager raw) =>
        _raw = raw;

    public GUser getSelf() =>
        new User((GlyUser)_raw.getSelf());

    public object raw() =>
        _raw;
}
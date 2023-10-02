namespace Glympse.EnRoute.iOS;

internal class Organization : GOrganization
{
    GlyOrganization _raw;

    public Organization(GlyOrganization raw) =>
        _raw = raw;

    public long getId() =>
        _raw.getId();

    public string getName() =>
        _raw.getName();

    public string getAdminEmail() =>
        _raw.getAdminEmail();

    public object raw() =>
        _raw;
}
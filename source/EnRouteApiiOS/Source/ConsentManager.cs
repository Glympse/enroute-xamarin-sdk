namespace Glympse.EnRoute.iOS;

internal class ConsentManager : GConsentManager
{
    GlyConsentManager _raw;

    public ConsentManager(GlyConsentManager raw) =>
        _raw = raw;

    public void exemptFromConsent(bool isExempt)
    {
        _raw.exemptFromConsent(isExempt);
    }

    public object raw() =>
        _raw;
}
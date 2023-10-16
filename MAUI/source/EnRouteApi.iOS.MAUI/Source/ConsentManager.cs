namespace Glympse.EnRoute.iOS
{
    class ConsentManager : GConsentManager
    {
        private GlyConsentManager _raw;

        public ConsentManager(GlyConsentManager raw)
        {
            _raw = raw;
        }

        public void exemptFromConsent(bool isExempt)
        {
            _raw.exemptFromConsent(isExempt);
        }

        public object raw()
        {
            return _raw;
        }
    }
}

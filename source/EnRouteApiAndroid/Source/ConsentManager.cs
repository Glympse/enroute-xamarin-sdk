using System;

namespace Glympse.EnRoute.Android
{
    class ConsentManager : GConsentManager
    {
        private com.glympse.android.api.GConsentManager _raw;

        public ConsentManager(com.glympse.android.api.GConsentManager raw)
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

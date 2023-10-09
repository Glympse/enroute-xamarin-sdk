using System;

namespace Glympse
{
    public interface GConsentManager : GCommon
    {
        void exemptFromConsent(bool isExempt);
    }
}

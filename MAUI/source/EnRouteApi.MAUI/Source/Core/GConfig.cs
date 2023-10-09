using System;

namespace Glympse
{
    public interface GConfig : GCommon
    {
        void setActiveSharingNotificationMessage(string message);

        // For possible modes see GlympseConstants::EXPIRE_ON_ARRIVAL_*
        void setExpireOnArrival(int mode);
    }
}

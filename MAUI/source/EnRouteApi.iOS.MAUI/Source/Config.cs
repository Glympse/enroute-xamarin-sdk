using System;

namespace Glympse.EnRoute.iOS
{
    class Config : GConfig
    {
        private GlyConfig _raw;

        public Config(GlyConfig raw)
        {
            _raw = raw;
        }

        public void setActiveSharingNotificationMessage(string message)
        {
            _raw.setActiveSharingNotificationMessage(message);
        }

        public void setExpireOnArrival(int mode)
        {
            _raw.setExpireOnArrival(mode);
        }

        public object raw()
        {
            return _raw;
        }
    }
}

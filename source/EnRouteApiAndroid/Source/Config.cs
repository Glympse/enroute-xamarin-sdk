using System;

namespace Glympse.EnRoute.Android
{
    class Config : GConfig
    {
        private com.glympse.android.api.GConfig _raw;

        public Config(com.glympse.android.api.GConfig raw)
        {
            _raw = raw;
        }

        public void setActiveSharingNotificationMessage(string message)
        {
            _raw.setActiveSharingNotificationMessage(message);
        }

        public object raw()
        {
            return _raw;
        }
    }
}

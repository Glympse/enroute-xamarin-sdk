using System;

namespace Glympse.EnRoute.Android
{
    class Invite : GInvite
    {
        private com.glympse.android.api.GInvite _raw;

        public Invite(com.glympse.android.api.GInvite raw)
        {
            _raw = raw;
        }

        public string getAddress()
        {
            return _raw.getAddress();
        }

        public int getType()
        {
            return _raw.getType();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

using System;

namespace Glympse.EnRoute.Android
{
    class UserManager : GUserManager
    {
        private com.glympse.android.api.GUserManager _raw;

        public UserManager(com.glympse.android.api.GUserManager raw)
        {
            _raw = raw;
        }

        public GUser getSelf()
        {
            return new User((com.glympse.android.api.GUser)_raw.getSelf());
        }

        public object raw()
        {
            return _raw;
        }
    }
}

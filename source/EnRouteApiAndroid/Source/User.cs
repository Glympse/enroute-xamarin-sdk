using System;

namespace Glympse.EnRoute.Android
{
    class User : GUser
    {
        private com.glympse.android.api.GUser _raw;

        public User(com.glympse.android.api.GUser raw)
        {
            _raw = raw;
        }

        public bool setNickname(string nickname)
        {
            return _raw.setNickname(nickname);
        }

        public string getNickname()
        {
            return _raw.getNickname();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

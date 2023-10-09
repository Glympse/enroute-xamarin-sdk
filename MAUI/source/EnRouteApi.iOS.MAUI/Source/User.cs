using System;

namespace Glympse.EnRoute.iOS
{
    class User : GUser
    {
        private GlyUser _raw;

        public User(GlyUser raw)
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

namespace Glympse.EnRoute.iOS
{
    class UserManager : GUserManager
    {
        private GlyUserManager _raw;

        public UserManager(GlyUserManager raw)
        {
            _raw = raw;
        }

        public GUser getSelf()
        {
            return new User((GlyUser)_raw.getSelf());
        }

        public object raw()
        {
            return _raw;
        }
    }
}

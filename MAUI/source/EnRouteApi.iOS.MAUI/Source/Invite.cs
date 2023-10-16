namespace Glympse.EnRoute.iOS
{
    class Invite : GInvite
    {
        private GlyInvite _raw;

        public Invite(GlyInvite raw)
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

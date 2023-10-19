namespace Glympse.EnRoute.iOS
{
    class Organization : GOrganization
    {
        private GlyOrganization _raw;

        public Organization(GlyOrganization raw)
        {
            _raw = raw;
        }

        public long getId()
        {
            return _raw.getId();
        }

        public string getName()
        {
            return _raw.getName();
        }

        public string getAdminEmail()
        {
            return _raw.getAdminEmail();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

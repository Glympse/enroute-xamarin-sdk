extern alias EnRouteApiDll;

namespace Glympse.EnRoute.UWP
{
    class Organization : GOrganization
    {
        private EnRouteApiDll::Glympse.EnRoute.GOrganization _raw;

        public Organization(EnRouteApiDll::Glympse.EnRoute.GOrganization raw)
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

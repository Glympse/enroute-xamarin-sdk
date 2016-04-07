using System;

namespace Glympse.EnRoute.Android
{
    class Organization : GOrganization
    {
        private com.glympse.enroute.android.api.GOrganization _raw;

        public Organization(com.glympse.enroute.android.api.GOrganization raw)
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

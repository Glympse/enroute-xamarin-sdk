using System;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GOrganization : GCommon
        {
            long getId();

            string getName();

            string getAdminEmail();
        }
    }
}

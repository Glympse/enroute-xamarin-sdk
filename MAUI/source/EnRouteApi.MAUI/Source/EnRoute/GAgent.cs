using System;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GAgent : GCommon
        {     
            long getId();

            string getName();

            string getEmail();
        }
    }
}

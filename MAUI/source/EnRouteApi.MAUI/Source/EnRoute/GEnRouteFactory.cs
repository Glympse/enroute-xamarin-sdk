using System;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GEnRouteFactory
        {
            GEnRouteManager createEnRouteManager();
        }
    }
}

extern alias EnRouteApiDll;
extern alias GlympseApiDll;

using System.Reflection;

namespace Glympse.EnRoute.UWP
{
    public class EnRouteFactory : GEnRouteFactory
    {
        private Assembly _assembly;

        public EnRouteFactory(Assembly entryAssembly)
        {
            _assembly = entryAssembly;
        }

        public GEnRouteManager createEnRouteManager()
        {
            EnRouteApiDll::Glympse.EnRoute.GEnRouteManager manager = EnRouteApiDll::Glympse.EnRoute.EnRouteFactory.createEnRouteManager(_assembly);
            return new EnRouteManager(manager);
        }            
    }
}

extern alias GlympseApiDll;
extern alias EnRouteApiDll;
extern alias GlympseApiToolboxDll;

using System.Collections.Generic;
using System.Reflection;

namespace Glympse.EnRoute.UWP
{
    public class AssemblyManager
    {
        public static List<Assembly> getAssemblyList()
        {
            List<Assembly> assembliesToInclude = new List<Assembly>();
            assembliesToInclude.Add(typeof(GlympseApiDll::Glympse.GGlympse).GetTypeInfo().Assembly);
            assembliesToInclude.Add(typeof(EnRouteApiDll::Glympse.EnRoute.GTaskManager).GetTypeInfo().Assembly);
            assembliesToInclude.Add(typeof(GlympseApiToolboxDll::Glympse.GSource).GetTypeInfo().Assembly);
            return assembliesToInclude;
        }
    }
}

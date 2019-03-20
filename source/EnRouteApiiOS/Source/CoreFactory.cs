using System;

namespace Glympse.EnRoute.iOS
{
    public static class CoreFactory
    {
        public static GPrimitive createPrimitive(string str)
        {
            return new Primitive(GlyCoreFactory.createPrimitive(str));
        }
    }
}

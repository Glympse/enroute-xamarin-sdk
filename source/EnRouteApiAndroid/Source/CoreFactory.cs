using System;

namespace Glympse.EnRoute.Android
{
    public class CoreFactory : GCoreFactory
    {
        public GPrimitive createPrimitive(string str)
        {
            return new Primitive(com.glympse.android.core.CoreFactory.createPrimitive(str));
        }
    }
}

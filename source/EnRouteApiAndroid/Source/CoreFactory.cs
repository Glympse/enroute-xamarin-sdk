using System;

namespace Glympse.EnRoute.Android
{
    public static class CoreFactory
    {
        public static GPrimitive createPrimitive(string str)
        {
            return new Primitive(com.glympse.android.core.CoreFactory.createPrimitive(str));
        }
    }
}

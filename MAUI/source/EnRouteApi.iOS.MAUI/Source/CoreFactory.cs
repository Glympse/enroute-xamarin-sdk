namespace Glympse.EnRoute.iOS
{
    public class CoreFactory : GCoreFactory
    {
        public GPrimitive createPrimitive(string str)
        {
            return new Primitive(GlyCoreFactory.createPrimitive(str));
        }

        public GPrimitive createPrimitiveArray()
        {
            return new Primitive(GlyCoreFactory.createPrimitive(1));
        }
    }
}

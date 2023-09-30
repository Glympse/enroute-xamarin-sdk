namespace Glympse.EnRoute.iOS;

public class CoreFactory : GCoreFactory
{
    public GPrimitive createPrimitive(string str) =>
        new Primitive(GlyCoreFactory.createPrimitive(str));
}
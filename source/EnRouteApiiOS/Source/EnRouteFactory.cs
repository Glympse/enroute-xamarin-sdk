namespace Glympse.EnRoute.iOS;

public class EnRouteFactory : GEnRouteFactory
{
    public GEnRouteManager createEnRouteManager() =>
        new EnRouteManager(GlyEnRouteFactory.createEnRouteManager());
}

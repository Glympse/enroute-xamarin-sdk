namespace Glympse.EnRoute.iOS
{
    public class EnRouteFactory : GEnRouteFactory
    {
        public GEnRouteManager createEnRouteManager()
        {
            return new EnRouteManager(GlyEnRouteFactory.createEnRouteManager());
        }            
    }
}

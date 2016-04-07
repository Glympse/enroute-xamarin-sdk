using System;

using Android.Content;

using Glympse;

namespace Glympse.EnRoute.Android
{
    public class EnRouteFactory : GEnRouteFactory
    {
        private Context _context;

        public EnRouteFactory(Context context)
        {
            _context = context;
        }

        public GEnRouteManager createEnRouteManager()
        {            
            return new EnRouteManager(com.glympse.enroute.android.api.EnRouteFactory.createEnRouteManager(_context));
        }            
    }
}

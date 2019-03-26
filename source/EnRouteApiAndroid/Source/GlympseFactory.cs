using System;
using Android.Content;

namespace Glympse.EnRoute.Android
{
    public class GlympseFactory : GGlympseFactory
    {
        private Context _context;

        public GlympseFactory(Context context)
        {
            _context = context;
        }

        public GGlympse createGlympse(string server, string apiKey)
        {
            return new Glympse(com.glympse.android.api.GlympseFactory.createGlympse(_context, server, apiKey));
        }

        public GInvite createInvite(int type, string name, string address)
        {
            return new Invite(com.glympse.android.api.GlympseFactory.createInvite(type, name, address));
        }

        public GPlace createPlace(double latitude, double longitude, string name)
        {
            return new Place(com.glympse.android.api.GlympseFactory.createPlace(latitude, longitude, name));
        }

        public GTicket createTicket(long duration, string message, GPlace destination)
        {
            com.glympse.android.api.GPlace nativeDestination = null;
            if ( null != destination )
            {
                nativeDestination = (com.glympse.android.api.GPlace)destination.raw();
            }

            return new Ticket(com.glympse.android.api.GlympseFactory.createTicket(duration, message, nativeDestination));
        }

        public GCoreFactory createCoreFactory()
        {
            return new CoreFactory();
        }
    }
}

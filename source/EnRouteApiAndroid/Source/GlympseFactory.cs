using System;

namespace Glympse.EnRoute.Android
{
    public static class GlympseFactory
    {
        /*GGlympse createGlympse(Context context, string server, string apiKey)
        {       
            return null; // TODO
        }*/

        public static GInvite createInvite(int type, string name, string address)
        {
            return new Invite(com.glympse.android.api.GlympseFactory.createInvite(type, name, address));
        }

        public static GPlace createPlace(double latitude, double longitude, string name)
        {
            return new Place(com.glympse.android.api.GlympseFactory.createPlace(latitude, longitude, name));
        }

        public static GTicket createTicket(long duration, string message, GPlace destination)
        {
            return new Ticket(com.glympse.android.api.GlympseFactory.createTicket(duration, message, (com.glympse.android.api.GPlace)destination.raw()));
        }
    }
}

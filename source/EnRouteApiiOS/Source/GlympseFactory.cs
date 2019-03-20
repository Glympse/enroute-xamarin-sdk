using System;

namespace Glympse.EnRoute.iOS
{
    public static class GlympseFactory
    {
        /*GGlympse createGlympse(Context context, string server, string apiKey)
        {       
            return null; // TODO
        }*/

        public static GInvite createInvite(int type, string name, string address)
        {
            return new Invite(GlyGlympseFactory.createInvite(type, name, address));
        }

        public static GPlace createPlace(double latitude, double longitude, string name)
        {
            return new Place(GlyGlympseFactory.createPlace(latitude, longitude, name));
        }

        public static GTicket createTicket(long duration, string message, GPlace destination)
        {
            return new Ticket(GlyGlympseFactory.createTicket(duration, message, (GlyPlace)destination.raw()));
        }
    }
}

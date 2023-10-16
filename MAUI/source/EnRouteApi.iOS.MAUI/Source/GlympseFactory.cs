namespace Glympse.EnRoute.iOS
{
    public class GlympseFactory : GGlympseFactory
    {
        public GGlympse createGlympse(string server, string apiKey)
        {
            return new Glympse(GlyGlympseFactory.createGlympse(server, apiKey));
        }

        public GInvite createInvite(int type, string name, string address)
        {
            return new Invite(GlyGlympseFactory.createInvite(type, name, address));
        }

        public GPlace createPlace(double latitude, double longitude, string name)
        {
            return new Place(GlyGlympseFactory.createPlace(latitude, longitude, name));
        }

        public GTicket createTicket(long duration, string message, GPlace destination)
        {
            GlyPlace nativeDestination = null;
            if ( null != destination )
            {
                nativeDestination = (GlyPlace)destination.raw();
            }
            return new Ticket(GlyGlympseFactory.createTicket(duration, message, nativeDestination));
        }

        public GPickupArrivalDataBuilder createPickupArrivalDataBuilder()
        {
            return new PickupArrivalDataBuilder(GlyGlympseFactory.createPickupArrivalDataBuilder());
        }

        public GCoreFactory createCoreFactory()
        {
            return new CoreFactory();
        }
    }
}

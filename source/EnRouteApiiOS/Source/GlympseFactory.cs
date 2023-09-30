namespace Glympse.EnRoute.iOS;

public class GlympseFactory : GGlympseFactory
{
    public GGlympse createGlympse(string server, string apiKey) =>
        new Glympse(GlyGlympseFactory.createGlympse(server, apiKey));

    public GInvite createInvite(int type, string name, string address) =>
        new Invite(GlyGlympseFactory.createInvite(type, name, address));

    public GPlace createPlace(double latitude, double longitude, string name) =>
        new Place(GlyGlympseFactory.createPlace(latitude, longitude, name));

    public GTicket createTicket(long duration, string message, GPlace destination)
    {
        GlyPlace nativeDestination = null;
        if ( null != destination )
        {
            nativeDestination = (GlyPlace)destination.raw();
        }
        return new Ticket(GlyGlympseFactory.createTicket(duration, message, nativeDestination));
    }

    public GPickupArrivalDataBuilder createPickupArrivalDataBuilder() =>
        new PickupArrivalDataBuilder(GlyGlympseFactory.createPickupArrivalDataBuilder());

    public GCoreFactory createCoreFactory() =>
        new CoreFactory();
}
namespace Glympse;

public interface GGlympseFactory
{
    GGlympse createGlympse(string server, string apiKey);

    GInvite createInvite(int type, string name, string address);

    GPlace createPlace(double latitude, double longitude, string name);

    GTicket createTicket(long duration, string message, GPlace destination);

    GPickupArrivalDataBuilder createPickupArrivalDataBuilder();

    GCoreFactory createCoreFactory();
}
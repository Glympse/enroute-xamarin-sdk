namespace Glympse;

public interface GCustomerPickupManager : GEventSink
{
    void setInviteCode(string inviteCode);

    void setForeignId(string foreignId);

    bool setManualETA(long eta);

    bool arrived();

    bool holdPickup();

    bool sendArrivalData(GPickupArrivalData arrivalData);

    bool sendFeedback(int customerRating, string customerComment, bool canContactCustomer);

    GCustomerPickup getCurrentPickup();

    bool sendChatMessage(string message);

    GArray<GChatMessage> getChatMessages();
}
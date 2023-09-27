namespace Glympse;

public interface GCustomerPickup : GCommon
{
    string getId();

    string getInviteCode();

    long getCreatedTime();

    long getDueTime();

    long getCompletedTime();

    long getArrivedTime();

    string getPhase();

    string getForeignId();

    GArray<GPrimitive> getMetadata();

    GPickupArrivalData getCustomerArrivalData();

    long getManualEta();

    string getChatRoomId();

    string getNotes();

    GArray<string> getChatEnabledPhases();
}
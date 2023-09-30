namespace Glympse.EnRoute.iOS;

internal class CustomerPickupManager : GCustomerPickupManager, EventSink.GGlyEventSink
{
    GlyCustomerPickupManager _raw;

    EventSink _eventSink;

    public CustomerPickupManager(GlyCustomerPickupManager raw)
    {
        _raw = raw;
        _eventSink = new EventSink(this);
    }

    /**
     * GCustomerPickupManager section
     */

    public bool arrived() =>
        _raw.arrived();

    public GArray<GChatMessage> getChatMessages() =>
        new Array<GChatMessage>(_raw.getChatMessages());

    public GCustomerPickup getCurrentPickup() =>
        (GCustomerPickup)ClassBinder.bind(_raw.getCurrentPickup());

    public bool holdPickup() =>
        _raw.holdPickup();

    public bool sendArrivalData(GPickupArrivalData arrivalData) =>
        _raw.sendArrivalData((GlyPickupArrivalData)arrivalData);

    public bool sendChatMessage(string message) =>
        _raw.sendChatMessage(message);

    public bool sendFeedback(int customerRating, string customerComment, bool canContactCustomer) =>
        _raw.sendFeedback(customerRating, customerComment, canContactCustomer);

    public void setForeignId(string foreignId)
    {
        _raw.setForeignId(foreignId);
    }

    public void setInviteCode(string inviteCode)
    {
        _raw.setInviteCode(inviteCode);
    }

    public bool setManualETA(long eta) =>
        _raw.setManualETA(eta);

    /**
     * GEventSink section
     */

    public bool addListener(GEventListener eventListener) =>
        _eventSink.addListener(eventListener);

    public bool removeListener(GEventListener eventListener) =>
        _eventSink.removeListener(eventListener);

    public bool addListener(GlyEventListener listener) =>
        _raw.addListener(listener);

    public bool removeListener(GlyEventListener listener) =>
        _raw.removeListener(listener);

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}
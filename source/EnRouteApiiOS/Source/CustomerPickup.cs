namespace Glympse.EnRoute.iOS;

internal class CustomerPickup : GCustomerPickup
{
    GlyCustomerPickup _raw;

    public CustomerPickup(GlyCustomerPickup raw) =>
        _raw = raw;

    /**
     * GCustomerPickup section
     */

    public string getId() =>
        _raw.getId();

    public string getInviteCode() =>
        _raw.getInviteCode();

    public long getCreatedTime() =>
        _raw.getCreatedTime();

    public long getDueTime() =>
        _raw.getDueTime();

    public long getCompletedTime() =>
        _raw.getCompletedTime();

    public long getArrivedTime() =>
        _raw.getArrivedTime();

    public string getPhase() =>
        _raw.getPhase();

    public string getForeignId() =>
        _raw.getForeignId();

    public GArray<GPrimitive> getMetadata() =>
        new Array<GPrimitive>(_raw.getMetadata());

    public GPickupArrivalData getCustomerArrivalData() =>
        (GPickupArrivalData)ClassBinder.bind(_raw.getCustomerArrivalData());

    public long getManualEta() =>
        _raw.getManualEta();

    public string getChatRoomId() =>
        _raw.getChatRoomId();

    public string getNotes() =>
        _raw.getNotes();

    public GArray<string> getChatEnabledPhases() =>
        new Array<string>(_raw.getChatEnabledPhases());

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}
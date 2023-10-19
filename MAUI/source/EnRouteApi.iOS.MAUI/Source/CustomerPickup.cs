namespace Glympse.EnRoute.iOS
{
    class CustomerPickup : GCustomerPickup
    {
        private GlyCustomerPickup _raw;

        public CustomerPickup(GlyCustomerPickup raw)
        {
            _raw = raw;
        }

        /**
         * GCustomerPickup section
         */

        public string getId()
        {
            return _raw.getId();
        }

        public string getInviteCode()
        {
            return _raw.getInviteCode();
        }

        public long getCreatedTime()
        {
            return _raw.getCreatedTime();
        }

        public long getDueTime()
        {
            return _raw.getDueTime();
        }

        public long getCompletedTime()
        {
            return _raw.getCompletedTime();
        }

        public long getArrivedTime()
        {
            return _raw.getArrivedTime();
        }

        public string getPhase()
        {
            return _raw.getPhase();
        }

        public string getForeignId()
        {
            return _raw.getForeignId();
        }

        public GArray<GPrimitive> getMetadata()
        {
            return new Array<GPrimitive>(_raw.getMetadata());
        }

        public GPickupArrivalData getCustomerArrivalData()
        {
            return (GPickupArrivalData)ClassBinder.bind(_raw.getCustomerArrivalData());
        }

        public long getManualEta()
        {
            return _raw.getManualEta();
        }

        public string getChatRoomId()
        {
            return _raw.getChatRoomId();
        }

        public string getNotes()
        {
            return _raw.getNotes();
        }

        public GArray<string> getChatEnabledPhases()
        {
            return new Array<string>(_raw.getChatEnabledPhases());
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}

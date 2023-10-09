using System;

namespace Glympse.EnRoute.Android
{
    class CustomerPickup : GCustomerPickup
    {
        private com.glympse.android.api.GCustomerPickup _raw;

        public CustomerPickup(com.glympse.android.api.GCustomerPickup raw)
        {
            _raw = raw;
        }

        /**
         * GCustomerPickup section
         */

        public long getArrivedTime()
        {
            return _raw.getArrivedTime();
        }

        public GArray<string> getChatEnabledPhases()
        {
            return new Array<string>(_raw.getChatEnabledPhases());
        }

        public string getChatRoomId()
        {
            return _raw.getChatRoomId();
        }

        public long getCompletedTime()
        {
            return _raw.getCompletedTime();
        }

        public long getCreatedTime()
        {
            return _raw.getCreatedTime();
        }

        public GPickupArrivalData getCustomerArrivalData()
        {
            return (GPickupArrivalData) _raw.getCustomerArrivalData();
        }

        public long getDueTime()
        {
            return _raw.getDueTime();
        }

        public string getForeignId()
        {
            return _raw.getForeignId();
        }

        public string getId()
        {
            return _raw.getId();
        }

        public string getInviteCode()
        {
            return _raw.getInviteCode();
        }

        public long getManualEta()
        {
            return _raw.getManualEta();
        }

        public GArray<GPrimitive> getMetadata()
        {
            return new Array<GPrimitive>(_raw.getMetadata());
        }

        public string getNotes()
        {
            return _raw.getNotes();
        }

        public string getPhase()
        {
            return _raw.getPhase();
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

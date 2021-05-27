using System;

namespace Glympse.EnRoute.Android
{
    class CustomerPickupManager : GCustomerPickupManager
    {
        private com.glympse.android.api.GCustomerPickupManager _raw;

        public CustomerPickupManager(com.glympse.android.api.GCustomerPickupManager raw)
        {
            _raw = raw;
        }

        /**
         * GCustomerPickupManager section
         */

        public bool arrived()
        {
            return _raw.arrived();
        }

        public GArray<GChatMessage> getChatMessages()
        {
            return new Array<GChatMessage>(_raw.getChatMessages());
        }

        public GCustomerPickup getCurrentPickup()
        {
            return (GCustomerPickup)_raw.getCurrentPickup();
        }

        public bool holdPickup()
        {
            return _raw.holdPickup();
        }

        public bool sendArrivalData(GPickupArrivalData arrivalData)
        {
            return _raw.sendArrivalData((com.glympse.android.api.GPickupArrivalData)arrivalData.raw());
        }

        public bool sendChatMessage(string message)
        {
            return _raw.sendChatMessage(message);
        }

        public bool sendFeedback(int customerRating, string customerComment)
        {
            return _raw.sendFeedback(customerRating, customerComment);
        }

        public void setForeignId(string foreignId)
        {
            _raw.setForeignId(foreignId);
        }

        public void setInviteCode(string inviteCode)
        {
            _raw.setInviteCode(inviteCode);
        }

        public bool setManualETA(long eta)
        {
            return _raw.setManualETA(eta);
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }

        /**
         * GEventSink section
         */

        public bool addListener(GEventListener eventListener)
        {
            return _raw.addListener((com.glympse.android.api.GEventListener)eventListener);
        }

        public bool removeListener(GEventListener eventListener)
        {
            return _raw.removeListener((com.glympse.android.api.GEventListener)eventListener);
        }
    }
}

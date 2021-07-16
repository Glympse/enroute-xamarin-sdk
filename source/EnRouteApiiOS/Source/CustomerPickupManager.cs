using System;

namespace Glympse.EnRoute.iOS
{
    class CustomerPickupManager : GCustomerPickupManager, EventSink.GGlyEventSink
    {
        private GlyCustomerPickupManager _raw;

        private EventSink _eventSink;

        public CustomerPickupManager(GlyCustomerPickupManager raw)
        {
            _raw = raw;
            _eventSink = new EventSink(this);
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
            return (GCustomerPickup)ClassBinder.bind(_raw.getCurrentPickup());
        }

        public bool holdPickup()
        {
            return _raw.holdPickup();
        }

        public bool sendArrivalData(GPickupArrivalData arrivalData)
        {
            return _raw.sendArrivalData((GlyPickupArrivalData)arrivalData);
        }

        public bool sendChatMessage(string message)
        {
            return _raw.sendChatMessage(message);
        }

        public bool sendFeedback(int customerRating, string customerComment, bool canContactCustomer)
        {
            return _raw.sendFeedback(customerRating, customerComment, canContactCustomer);
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
         * GEventSink section
         */

        public bool addListener(GEventListener eventListener)
        {
            return _eventSink.addListener(eventListener);
        }

        public bool removeListener(GEventListener eventListener)
        {
            return _eventSink.removeListener(eventListener);
        }

        public bool addListener(GlyEventListener listener)
        {
            return _raw.addListener(listener);
        }

        public bool removeListener(GlyEventListener listener)
        {
            return _raw.removeListener(listener);
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

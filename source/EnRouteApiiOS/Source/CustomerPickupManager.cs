using System;

namespace Glympse.EnRoute.iOS
{
    class CustomerPickupManager : GCustomerPickupManager
    {
        private GlyCustomerPickupManager _raw;

        public CustomerPickupManager(GlyCustomerPickupManager raw)
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
    }
}

using System;
using Glympse.Toolbox;

namespace Glympse
{
    public interface GCustomerPickupManager : GCommon
    {
        void setInviteCode(string inviteCode);

        void setForeignId(string foreignId);

        bool setManualETA(long eta);

        bool arrived();

        bool holdPickup();

        bool sendArrivalData(GPickupArrivalData arrivalData);

        bool sendFeedback(int customerRating, string customerComment);

        GCustomerPickup getCurrentPickup();

        bool sendChatMessage(string message);

        GArray<GChatMessage> getChatMessages();
    }
}

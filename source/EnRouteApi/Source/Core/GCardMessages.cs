using System;

namespace Glympse
{
    public interface GCardMessages : GCommon
    {
        GArray<GCardMessage> getMessageList();

        string getCardId();

        string sendMessage(string message);

        bool hasUnreadMessages();

        bool confirmRead(GCardMessage cardMessage);

        bool confirmReadById(string messageId);
    }
}

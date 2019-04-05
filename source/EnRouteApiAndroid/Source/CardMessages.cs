using System;

namespace Glympse.EnRoute.Android
{
    class CardMessages : GCardMessages
    {
        private com.glympse.android.api.GCardMessages _raw;

        public CardMessages(com.glympse.android.api.GCardMessages raw)
        {
            _raw = raw;
        }

        public bool confirmRead(GCardMessage cardMessage)
        {
            return _raw.confirmRead((com.glympse.android.api.GCardMessage)cardMessage.raw());
        }

        public bool confirmReadById(string messageId)
        {
            return _raw.confirmReadById(messageId);
        }

        public string getCardId()
        {
            return _raw.getCardId();
        }

        public GArray<GCardMessage> getMessageList()
        {
            return new Array<GCardMessage>(_raw.getMessageList());
        }

        public bool hasUnreadMessages()
        {
            return _raw.hasUnreadMessages();
        }

        public string sendMessage(string message)
        {
            return _raw.sendMessage(message);
        }

        public object raw()
        {
            return _raw;
        }
    }
}

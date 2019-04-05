using System;

namespace Glympse.EnRoute.iOS
{
    class CardMessages : GCardMessages
    {
        private GlyCardMessages _raw;

        public CardMessages(GlyCardMessages raw)
        {
            _raw = raw;
        }

        public bool confirmRead(GCardMessage cardMessage)
        {
            return _raw.confirmRead((GlyCardMessage)cardMessage);
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

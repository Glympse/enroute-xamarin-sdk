using System;

namespace Glympse.EnRoute.iOS
{
    class CardMessage : GCardMessage
    {
        private GlyCardMessage _raw;

        public CardMessage(GlyCardMessage raw)
        {
            _raw = raw;
        }

        public long getCreatedTime()
        {
            return _raw.getCreatedTime();
        }

        public string getId()
        {
            return _raw.getId();
        }

        public string getSenderAvatarUrl()
        {
            return _raw.getSenderAvatarUrl();
        }

        public string getSenderNickname()
        {
            return _raw.getSenderNickname();
        }

        public string getSenderUserId()
        {
            return _raw.getSenderUserId();
        }

        public string getText()
        {
            return _raw.getText();
        }

        public bool isRead()
        {
            return _raw.isRead();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

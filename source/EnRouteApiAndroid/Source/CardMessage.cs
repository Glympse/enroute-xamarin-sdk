using System;

namespace Glympse.EnRoute.Android
{
    class CardMessage : GCardMessage
    {
        private com.glympse.android.api.GCardMessage _raw;

        public CardMessage(com.glympse.android.api.GCardMessage raw)
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

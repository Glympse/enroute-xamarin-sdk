using System;

namespace Glympse.EnRoute.iOS
{
    class ChatRoom : GChatRoom
    {
        private GlyChatRoom _raw;

        public ChatRoom(GlyChatRoom raw)
        {
            _raw = raw;
        }

        /**
         * GChatRoom section
         */

        public string getName()
        {
            return _raw.getName();
        }

        public GArray<GChatMessage> getChatMessages()
        {
            return new Array<GChatMessage>(_raw.getChatMessages());
        }

        public long getSequenceNumber()
        {
            return _raw.getSequenceNumber();
        }

        public long getLastReadSequenceNumber()
        {
            return _raw.getLastReadSequenceNumber();
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

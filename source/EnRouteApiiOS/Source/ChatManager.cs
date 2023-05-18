using System;

namespace Glympse.EnRoute.iOS
{
    class ChatManager : GChatManager, EventSink.GGlyEventSink
    {
        private GlyChatManager _raw;

        private EventSink _eventSink;

        public ChatManager(GlyChatManager raw)
        {
            _raw = raw;
            _eventSink = new EventSink(this);
        }

        /**
         * GChatManager section
         */

        public GChatRoom getChatRoom(string roomId)
        {
            return (GChatRoom)_raw.getChatRoom(roomId);
        }

        public void setRoomAsRead(string roomId)
        {
            _raw.setRoomAsRead(roomId);
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

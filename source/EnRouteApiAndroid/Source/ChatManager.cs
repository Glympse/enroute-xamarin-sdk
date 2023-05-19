using System;

namespace Glympse.EnRoute.Android
{
    class ChatManager : GChatManager
    {
        private com.glympse.android.api.GChatManager _raw;

        private EventSink _eventSink;

        public ChatManager(com.glympse.android.api.GChatManager raw)
        {
            _raw = raw;
            _eventSink = new EventSink(raw);
        }

        public GChatRoom getChatRoom(string roomId)
        {
            return (GChatRoom)ClassBinder.bind(_raw.getChatRoom(roomId));

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

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}

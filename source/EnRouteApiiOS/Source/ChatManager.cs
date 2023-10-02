namespace Glympse.EnRoute.iOS;

internal class ChatManager : GChatManager, EventSink.GGlyEventSink
{
    GlyChatManager _raw;

    EventSink _eventSink;

    public ChatManager(GlyChatManager raw)
    {
        _raw = raw;
        _eventSink = new EventSink(this);
    }

    /**
     * GChatManager section
     */

    public GChatRoom getChatRoom(string roomId) =>
        new ChatRoom(_raw.getChatRoom(roomId));

    public void setRoomAsRead(string roomId)
    {
        _raw.setRoomAsRead(roomId);
    }

    /**
     * GEventSink section
     */

    public bool addListener(GEventListener eventListener) =>
        _eventSink.addListener(eventListener);

    public bool removeListener(GEventListener eventListener) =>
        _eventSink.removeListener(eventListener);

    public bool addListener(GlyEventListener listener) =>
        _raw.addListener(listener);

    public bool removeListener(GlyEventListener listener) =>
        _raw.removeListener(listener);

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}
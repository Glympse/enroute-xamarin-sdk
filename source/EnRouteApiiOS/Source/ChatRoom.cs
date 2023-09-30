namespace Glympse.EnRoute.iOS;

internal class ChatRoom : GChatRoom
{
    GlyChatRoom _raw;

    public ChatRoom(GlyChatRoom raw) =>
        _raw = raw;

    /**
     * GChatRoom section
     */

    public string getName() =>
        _raw.getName();

    public GArray<GChatMessage> getChatMessages() =>
        new Array<GChatMessage>(_raw.getChatMessages());

    public long getSequenceNumber() =>
        _raw.getSequenceNumber();

    public long getLastReadSequenceNumber() =>
        _raw.getLastReadSequenceNumber();

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}

namespace Glympse;

public interface GChatManager : GEventSink
{
    GChatRoom getChatRoom(string roomId);

    void setRoomAsRead(string roomId);
}
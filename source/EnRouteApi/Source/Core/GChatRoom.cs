namespace Glympse;

public interface GChatRoom : GCommon
{
    string getName();

    GArray<GChatMessage> getChatMessages();

    long getSequenceNumber();

    long getLastReadSequenceNumber();
}
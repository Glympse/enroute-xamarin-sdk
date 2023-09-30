namespace Glympse.EnRoute.iOS;

internal class ChatMessage : GChatMessage
{
    GlyChatMessage _raw;

    public ChatMessage(GlyChatMessage raw) =>
        _raw = raw;

    /**
     * GChatMessage section
     */

    public long getId() =>
        _raw.getId();

    public long getCreatedTime() =>
        _raw.getCreatedTime();

    public string getContents() =>
        _raw.getContents();

    public string getAuthor() =>
        _raw.getAuthor();

    public long getSequenceId() =>
        _raw.getSequenceId();

    public bool isAgent() =>
        _raw.isAgent();

    /**
     * GCommon section
     */

    public object raw() =>
        _raw;
}
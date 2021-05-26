using System;

namespace Glympse
{
    public interface GChatMessage : GCommon
    {
        long getId();

        long getCreatedTime();

        string getContents();

        string getAuthor();

        long getSequenceId();
    }
}

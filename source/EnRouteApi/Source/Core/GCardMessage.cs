using System;

namespace Glympse
{
    public interface GCardMessage : GCommon
    {
        string getId();

        Int64 getCreatedTime();

        string getText();

        string getSenderUserId();

        string getSenderNickname();

        string getSenderAvatarUrl();

        bool isRead();
    }
}

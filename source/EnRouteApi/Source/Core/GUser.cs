using System;

namespace Glympse
{
    public interface GUser : GCommon
    {
        bool setNickname(string nickname);

        string getNickname();
    }
}

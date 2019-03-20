using System;

namespace Glympse
{
    public interface GTicket : GCommon
    {
        string getId();

        bool appendData(long partnerId, string name, GPrimitive value);

        bool expire();

        void updateEta(long eta);

        bool extend(long interval);

        long getEta();

        bool modify(long remaining, string message, GPlace destination);

        GArray<GInvite> getInvites();

        long getDuration();

    }
}

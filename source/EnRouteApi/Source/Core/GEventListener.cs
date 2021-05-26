using System;

namespace Glympse
{
    public interface GEventListener : GCommon
    {
        void eventsOccurred(GGlympse glympse, int listener, int events, object param);
    }
}

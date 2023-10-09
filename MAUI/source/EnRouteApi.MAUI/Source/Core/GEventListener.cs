using System;

namespace Glympse
{
    public interface GEventListener
    {
        void eventsOccurred(GGlympse glympse, int listener, int events, object param);
    }
}

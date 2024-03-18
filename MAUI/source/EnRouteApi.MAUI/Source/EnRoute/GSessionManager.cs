using System;
using Glympse.Toolbox;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GSessionManager : GSource
        {
            bool isStarted();

            void refresh();
            
            GArray<GSession> getSessions();

            bool anyActiveSessions();

            GSession findSessionById(long sessionId);
        }
    }
}

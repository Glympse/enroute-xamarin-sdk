using System;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GTask : GCommon
        {
            int getState();

            long getId();

            GOperation getOperation();

            string getDescription();

            long getDueTime();

            string getPhase();

            string getForeignId();

            string getChatRoomId();
        }
    }
}

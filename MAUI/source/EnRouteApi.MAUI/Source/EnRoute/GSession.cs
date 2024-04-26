using System;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GSession : GCommon
        {
            long getId();

            long getCreatedTime();

            string getDescription();

            GArray<GTask> getTasks();

            GTask getActiveTask();

            int getActiveTaskIndex();

            int getState();

            long getStartTime();

            long getOrgId();

            long getAgentId();

            int getCompletionReason();
        }
    }
}

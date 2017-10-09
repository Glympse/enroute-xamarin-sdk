using System;
using Glympse.Toolbox;

namespace Glympse
{
    namespace EnRoute
    {
        public interface GTaskManager : GSource
        {
            GArray<GTask> getTasks();

            GArray<GTask> getPendingTasks();

            GArray<GOperation> getActiveOperations();

            GTask findTaskById(long id);

            bool startTask(GTask task);

            bool setTaskPhase(GTask task, string phase);

            bool completeOperation(GOperation operation);
        }
    }
}

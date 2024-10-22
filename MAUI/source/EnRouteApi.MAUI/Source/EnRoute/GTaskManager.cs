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

            bool completeOperation(GOperation operation, int reasonCode);

            void setTravelModeForTask(GTask task, string travelMode);

            string getTravelModeForTask(GTask task);

            bool sendMessage(GTask task, string message);

            void saveManualSortOrder(GPrimitive taskIdArray);

            GPrimitive getManualSortOrder();
        }
    }
}

using System;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    /**
     * Demonstrates basic task management operations. 
     */
    public class Tasks
    {
        public static void tasks(GEnRouteManager manager)
        {
            GTaskManager taskManager = manager.getTaskManager();

            // Enumerate tasks
            foreach ( GTask taskFromList in taskManager.getTasks() ) 
            {
                // Do something with each task
            }

            // Start top pending task. Notes
            // - task list may be empty
            GTask task = taskManager.getPendingTasks().at(0);
            taskManager.startTask(task);

            // Change task phase to "live". Notes
            // - task needs to be in active state
            // - operation object needs to be available
            taskManager.setOperationPhase(task.getOperation(), EnRouteConstants.PHASE_PROPERTY_LIVE());

            // Complete task. Notes
            // - task needs to be in active state
            // - operation object needs to be available
            taskManager.completeOperation(task.getOperation());
        }
    }
}


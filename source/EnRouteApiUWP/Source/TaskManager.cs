extern alias EnRouteApiDll;
extern alias GlympseApiDll;

using Glympse.Toolbox;

namespace Glympse.EnRoute.UWP
{
    class TaskManager : GTaskManager
    {
        private EnRouteApiDll::Glympse.EnRoute.GTaskManager _raw;

        private CommonSource _source;

        public TaskManager(EnRouteApiDll::Glympse.EnRoute.GTaskManager raw)
        {
            _raw = raw;        
            _source = new CommonSource(_raw);
        }

        /**
         * GTaskManager section
         */       

        public GArray<GTask> getTasks()
        {
            return null;// return new Array<GTask>(_raw.getTasks());
        }

        public GArray<GTask> getPendingTasks()
        {
            return null; // return new Array<GTask>(_raw.getPendingTasks());
        }

        public GArray<GOperation> getActiveOperations()
        {
            return null; // return new Array<GOperation>(_raw.getActiveOperations());
        }

        public GTask findTaskById(long id)
        {
            return (GTask)ClassBinder.bind(_raw.findTaskById(id));
        }

        public bool startTask(GTask task)
        {
            return _raw.startTask((EnRouteApiDll::Glympse.EnRoute.GTask)task.raw());
        }

        public bool setOperationPhase(GOperation operation, string phase)
        {
            return _raw.setOperationPhase((EnRouteApiDll::Glympse.EnRoute.GOperation)operation.raw(), phase);
        }

        public bool completeOperation(GOperation operation)
        {
            return _raw.completeOperation((EnRouteApiDll::Glympse.EnRoute.GOperation)operation.raw());
        }

        /**
         * GSource section
         */

        public bool addListener(GListener listener)
        {
            return _source.addListener(listener);

        }            

        public bool removeListener(GListener listener)
        {
            return _source.removeListener(listener);
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}


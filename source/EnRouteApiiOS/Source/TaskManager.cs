using System;
using Glympse.Toolbox;

namespace Glympse.EnRoute.iOS
{
    class TaskManager : GTaskManager, CommonSource.GGlySource
    {
        private GlyTaskManager _raw;

        private CommonSource _source;

        public TaskManager(GlyTaskManager raw)
        {
            _raw = raw;        
            _source = new CommonSource(this);
        }

        /**
         * GTaskManager section
         */       

        public GArray<GTask> getTasks()
        {
            return new Array<GTask>(_raw.getTasks());
        }

        public GArray<GTask> getPendingTasks()
        {
            return new Array<GTask>(_raw.getPendingTasks());
        }

        public GArray<GOperation> getActiveOperations()
        {
            return new Array<GOperation>(_raw.getActiveOperations());
        }

        public GTask findTaskById(long id)
        {
            return (GTask)ClassBinder.bind(_raw.findTaskById(id));
        }

        public bool startTask(GTask task)
        {
            return _raw.startTask((GlyTask)task.raw());
        }

        public bool setOperationPhase(GOperation operation, string phase)
        {
            return _raw.setOperationPhase((GlyOperation)operation.raw(), phase);
        }

        public bool completeOperation(GOperation operation)
        {
            return _raw.completeOperation((GlyOperation)operation.raw());
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

        public bool addListener(GlyListener listener)
        {
            return _raw.addListener(listener);
        }

        public bool removeListener(GlyListener listener)
        {
            return _raw.removeListener(listener);
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


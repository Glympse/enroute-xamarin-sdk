﻿using Glympse.Toolbox;

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

        public bool setTaskPhase(GTask task, string phase)
        {
            return _raw.setTaskPhase((GlyTask)task.raw(), phase);
        }

        public bool completeOperation(GOperation operation)
        {
            return _raw.completeOperation((GlyOperation)operation.raw());
        }

        public bool completeOperation(GOperation operation, int reasonCode)
        {
            return _raw.completeOperation((GlyOperation)operation.raw(), reasonCode);
        }

        public void setTravelModeForTask(GTask task, string travelMode)
        {
            _raw.setTravelModeForTask((GlyTask)task.raw(), travelMode);
        }

        public string getTravelModeForTask(GTask task)
        {
            return _raw.getTravelModeForTask((GlyTask)task.raw());
        }

        public bool sendMessage(GTask task, string message)
        {
            return _raw.sendMessage((GlyTask)task.raw(), message);
        }

        public void saveManualSortOrder(GPrimitive taskIdArray)
        {
            _raw.saveManualSortOrder((GlyPrimitive)taskIdArray.raw());
        }

        public GPrimitive getManualSortOrder()
        {
            return (GPrimitive)ClassBinder.bind(_raw.getManualSortOrder());
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


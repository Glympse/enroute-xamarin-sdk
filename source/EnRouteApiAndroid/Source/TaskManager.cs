﻿using System;
using Glympse.Toolbox;

namespace Glympse.EnRoute.Android
{
    class TaskManager : GTaskManager
    {
        private com.glympse.enroute.android.api.GTaskManager _raw;

        private CommonSource _source;

        public TaskManager(com.glympse.enroute.android.api.GTaskManager raw)
        {
            _raw = raw;        
            _source = new CommonSource(_raw);
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
            return _raw.startTask((com.glympse.enroute.android.api.GTask)task.raw());
        }

        public bool setTaskPhase(GTask task, string phase)
        {
            return _raw.setTaskPhase((com.glympse.enroute.android.api.GTask)task.raw(), phase);
        }

        public bool completeOperation(GOperation operation)
        {
            return _raw.completeOperation((com.glympse.enroute.android.api.GOperation)operation.raw());
        }

        public GCardMessages getCardMessagesForTask(GTask task)
        {
            return new CardMessages(_raw.getCardMessagesForTask((com.glympse.enroute.android.api.GTask)task.raw()));
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


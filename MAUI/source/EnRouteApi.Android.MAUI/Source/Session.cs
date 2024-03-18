using System;

namespace Glympse.EnRoute.Android
{
    class Session : GSession
    {
        private com.glympse.enroute.android.api.GSession _raw;

        public Session(com.glympse.enroute.android.api.GSession raw)
        {
            _raw = raw;
        }

        public long getId()
        {
            return _raw.getId();
        }

        public long getCreatedTime()
        {
            return _raw.getCreatedTime();
        }

        public string getDescription()
        {
            return _raw.getDescription();
        }

        public GArray<GTask> getTasks()
        {
            return new Array<GTask>(_raw.getTasks());
        }
        
        public GTask getActiveTask()
        {
            return (GTask)ClassBinder.bind(_raw.getActiveTask());
        }

        public int getActiveTaskIndex()
        {
            return _raw.getActiveTaskIndex();
        }

        public int getState()
        {
            return _raw.getState();
        }

        public long getStartTime()
        {
            return _raw.getStartTime();
        }

        public long getOrgId()
        {
            return _raw.getOrgId();
        }

        public long getAgentId()
        {
            return _raw.getAgentId();
        }

        public long getOperationId()
        {
            return _raw.getOperationId();
        }

        public GOperation getOperation()
        {
            return (GOperation)ClassBinder.bind(_raw.getOperation());
        }

        public int getCompletionReason()
        {
            return _raw.getCompletionReason();
        }
        
        public object raw()
        {
            return _raw;
        }
    }
}

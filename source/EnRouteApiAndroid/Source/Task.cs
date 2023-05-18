using System;

namespace Glympse.EnRoute.Android
{
    class Task : GTask
    {
        private com.glympse.enroute.android.api.GTask _raw;

        public Task(com.glympse.enroute.android.api.GTask raw)
        {
            _raw = raw;
        }

        public int getState()
        {
            return _raw.getState();
        }

        public long getId()
        {
            return _raw.getId();
        }

        public GOperation getOperation()
        {
            return (GOperation)ClassBinder.bind(_raw.getOperation());
        }

        public string getDescription()
        {
            return _raw.getDescription();
        }

        public long getDueTime()
        {
            return _raw.getDueTime();
        }

        public string getPhase()
        {
            return _raw.getPhase();
        }

        public string getForeignId()
        {
            return _raw.getForeignId();
        }

        public string getChatRoomId()
        {
            return _raw.getChatRoomId();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

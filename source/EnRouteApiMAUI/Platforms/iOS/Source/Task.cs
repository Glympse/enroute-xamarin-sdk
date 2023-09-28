using System;

namespace Glympse.EnRoute.iOS
{
    class Task : GTask
    {
        private GlyTask _raw;

        public Task(GlyTask raw)
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

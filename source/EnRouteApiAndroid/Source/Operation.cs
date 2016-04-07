using System;

namespace Glympse.EnRoute.Android
{
    class Operation : GOperation
    {
        private com.glympse.enroute.android.api.GOperation _raw;

        public Operation(com.glympse.enroute.android.api.GOperation raw)
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

        public long getStartTime()
        {
            return _raw.getStartTime();
        }

        public string getTicketId()
        {
            return _raw.getTicketId();
        }

        public string getInviteUrl()
        {
            return _raw.getInviteUrl();
        }

        public string getInviteCode()
        {
            return _raw.getInviteCode();
        }

        public long getTaskId()
        {
            return _raw.getTaskId();
        }

        public void setTicketEta(long eta)
        {
            _raw.setTicketEta(eta);
        }

        public string getTicketPhase()
        {
            return _raw.getTicketPhase();
        }

        public string getPhase()
        {
            return _raw.getPhase();
        }

        public object raw()
        {
            return _raw;
        }
    }
}

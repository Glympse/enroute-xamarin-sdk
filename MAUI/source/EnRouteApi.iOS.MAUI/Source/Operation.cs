using System;

namespace Glympse.EnRoute.iOS
{
    class Operation : GOperation
    {
        private GlyOperation _raw;

        public Operation(GlyOperation raw)
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

        public void setTicketVisible(string visible)
        {
            _raw.setTicketVisible(visible);
        }

        public object raw()
        {
            return _raw;
        }
    }
}

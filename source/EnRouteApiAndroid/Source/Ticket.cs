using System;

namespace Glympse.EnRoute.Android
{
    class Ticket : GTicket
    {
        private com.glympse.android.api.GTicket _raw;

        public Ticket(com.glympse.android.api.GTicket raw)
        {
            _raw = raw;
        }

        public bool appendData(long partnerId, string name, GPrimitive value)
        {
            return _raw.appendData(partnerId, name, (com.glympse.android.core.GPrimitive)value.raw());
        }

        public bool expire()
        {
            return _raw.expire();
        }

        public bool extend(long interval)
        {
            return _raw.extend(interval);
        }

        public long getDuration()
        {
            return _raw.getDuration();
        }

        public long getEta()
        {
            return _raw.getEta();
        }

        public string getId()
        {
            return _raw.getId();
        }

        public GArray<GInvite> getInvites()
        {
            return new Array<GInvite>(_raw.getInvites());
        }

        public bool modify(long remaining, string message, GPlace destination)
        {
            return _raw.modify(remaining, message, (com.glympse.android.api.GPlace)destination.raw());
        }

        public void updateEta(long eta)
        {
            _raw.updateEta(eta);
        }

        public object raw()
        {
            return _raw;
        }
    }
}

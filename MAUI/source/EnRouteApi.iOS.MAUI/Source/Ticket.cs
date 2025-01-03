﻿namespace Glympse.EnRoute.iOS
{
    class Ticket : GTicket
    {
        private GlyTicket _raw;

        public Ticket(GlyTicket raw)
        {
            _raw = raw;
        }

        public bool appendData(long partnerId, string name, GPrimitive value)
        {
            return _raw.appendData(partnerId, name, (GlyPrimitive)value.raw());
        }

        public bool addInvite(GInvite invite)
        {
            return _raw.addInvite((GlyInvite)invite.raw());
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
            return _raw.modify(remaining, message, (GlyPlace)destination.raw());
        }

        public void updateEta(long eta)
        {
            _raw.updateEta(eta);
        }

        public GPlace getDestination()
        {
            return (GPlace)ClassBinder.bind(_raw.getDestination());
        }

        public GTrack getTrack()
        {
            return (GTrack)ClassBinder.bind(_raw.getTrack());
        }

        public GTrack getRoute()
        {
            return (GTrack)ClassBinder.bind(_raw.getRoute());
        }

        public object raw()
        {
            return _raw;
        }
    }
}

using Glympse.Toolbox;

namespace Glympse.EnRoute.iOS
{
    class SessionManager : GSessionManager, CommonSource.GGlySource
    {
        private GlySessionManager _raw;

        private CommonSource _source;

        public SessionManager(GlySessionManager raw)
        {
            _raw = raw;        
            _source = new CommonSource(this);
        }

        /**
         * GSessionManager section
         */       

        public bool isStarted()
        {
            return _raw.isStarted();
        }

        public void refresh()
        {
            _raw.refresh();
        }

        public GArray<GSession> getSessions()
        {
            return new Array<GSession>(_raw.getSessions());
        }

        public bool anyActiveSessions()
        {
            return _raw.anyActiveSessions();
        }

        public GSession findSessionById(long sessionId)
        {
            return (GSession)ClassBinder.bind(_raw.findSessionById(sessionId));
        }

        public void startSession(GSession session)
        {
            _raw.startSession((GlySession)session.raw());
        }

        public void arriveTaskForSession(GSession session, GTask task)
        {
            _raw.arriveTaskForSession((GlySession)session.raw(), (GlyTask)task.raw());
        }

        public void departTaskForSession(GSession session, GTask task)
        {
            _raw.departTaskForSession((GlySession)session.raw(), (GlyTask)task.raw());
        }

        public void completeSession(GSession session)
        {
            _raw.completeSession((GlySession)session.raw());
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


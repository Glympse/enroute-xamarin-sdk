using System;
using Glympse.Toolbox;

namespace Glympse.EnRoute.Android
{
    class SessionManager : GSessionManager
    {
        private com.glympse.enroute.android.api.GSessionManager _raw;

        private CommonSource _source;

        public SessionManager(com.glympse.enroute.android.api.GSessionManager raw)
        {
            _raw = raw;        
            _source = new CommonSource(_raw);
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
            _raw.startSession((com.glympse.enroute.android.api.GSession)session.raw());
        }

        public void arriveTaskForSession(GSession session, GTask task)
        {
            _raw.arriveTaskForSession((com.glympse.enroute.android.api.GSession)session.raw(), (com.glympse.enroute.android.api.GTask)task.raw());
        }

        public void departTaskForSession(GSession session, GTask task)
        {
            _raw.departTaskForSession((com.glympse.enroute.android.api.GSession)session.raw(), (com.glympse.enroute.android.api.GTask)task.raw());
        }

        public void completeSession(GSession session)
        {
            _raw.completeSession((com.glympse.enroute.android.api.GSession)session.raw());
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


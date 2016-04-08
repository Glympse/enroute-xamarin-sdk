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

		public GArray<GSession> getSessions()
		{
			return new Array<GSession>(_raw.getSessions());
		}

		public GSession getCurrentSession()
		{
			return (GSession)ClassBinder.bind(_raw.getCurrentSession());
		}

		public GSession findSessionById(long sessionId)
		{
			return (GSession)ClassBinder.bind(_raw.findSessionById(sessionId));
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
	
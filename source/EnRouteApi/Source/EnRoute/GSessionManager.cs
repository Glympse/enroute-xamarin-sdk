using System;
using Glympse.Toolbox;

namespace Glympse
{
	namespace EnRoute
	{
		public interface GSessionManager : GSource
		{
			GArray<GSession> getSessions();

			GSession getCurrentSession();

			GSession findSessionById(long sessionId);
		}
	}
}
	
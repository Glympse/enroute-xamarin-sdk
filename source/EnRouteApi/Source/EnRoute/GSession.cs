using System;

namespace Glympse
{
	namespace EnRoute
	{
		public interface GSession : GCommon
		{
			long getId();

			long getCreatedTime();

			string getDescription();

			GArray<GTask> getTasks();

			int getState();

			long getStartTime();

			long getOrgId();

			long getAgentId();

			long getOperationId();

			GOperation getOperation();

			int getCompletionReason();
		}
	}
}


using System;

namespace Glympse
{
    namespace Toolbox
    {
        public interface GSource : GCommon
        {
            bool addListener(GListener listener);

            bool removeListener(GListener listener);
        }
    }
}

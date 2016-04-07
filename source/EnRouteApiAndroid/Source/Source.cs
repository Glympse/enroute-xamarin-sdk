using System;

namespace Glympse.EnRoute.Android
{
    public class Source : GSource
    {
        private com.glympse.android.toolbox.listener.GSource _raw;       

        public Source(com.glympse.android.toolbox.listener.GSource source)
        {
            _raw = source;        
        }

        public bool addListener(GListener listener)
        {
            return _raw.addListener((com.glympse.android.toolbox.listener.GListener)listener.raw());
        }

        public void removeListener(GListener listener)
        {
            _raw.removeListener((com.glympse.android.toolbox.listener.GListener)listener.raw());
        }

        public object raw()
        {
            return _raw;
        }
    }
}


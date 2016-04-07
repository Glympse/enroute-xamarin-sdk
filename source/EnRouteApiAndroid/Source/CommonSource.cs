using System;
using System.Collections.Generic;
using Glympse.Toolbox;

namespace Glympse.EnRoute.Android
{
    public class CommonSource
    {
        public class ListenerWrapper : Java.Lang.Object, com.glympse.android.toolbox.listener.GListener
        {
            private GListener _listener; 

            public ListenerWrapper(GListener listener)
            {
                _listener = listener;
            }

            public void eventsOccurred(
                com.glympse.android.toolbox.listener.GSource source, 
                int listener, 
                int events, 
                Java.Lang.Object param1, 
                Java.Lang.Object param2)
            {
                _listener.eventsOccurred(
                    (GSource)ClassBinder.bind(source), 
                    listener, 
                    events, 
                    ClassBinder.bind(param1), 
                    ClassBinder.bind(param2));
            }
        }

        private com.glympse.android.toolbox.listener.GSource _raw;

        private Dictionary<GListener, ListenerWrapper> _wrappers;

        public CommonSource(com.glympse.android.toolbox.listener.GSource raw)
        {
            _raw = raw;
            _wrappers = new Dictionary<GListener, ListenerWrapper>();
        }

        public bool addListener(GListener listener)
        { 
            ListenerWrapper wrapper = new ListenerWrapper(listener);
            bool result = _raw.addListener(wrapper);
            if ( result ) 
            {
                _wrappers[listener] = wrapper;
            }
            return result;
        }            

        public bool removeListener(GListener listener)
        {
            bool result = false;
            if ( _wrappers.ContainsKey(listener) )
            {
                ListenerWrapper wrapper = _wrappers[listener];
                result = _raw.removeListener(wrapper); 
                _wrappers.Remove(listener);
            }
            return result;
        }
    }
}

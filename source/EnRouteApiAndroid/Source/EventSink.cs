using System;
using System.Collections.Generic;

namespace Glympse.EnRoute.Android
{
    public class EventSink
    {
        public class ListenerWrapper : Java.Lang.Object, com.glympse.android.api.GEventListener
        {
            private GEventListener _listener;

            public ListenerWrapper(GEventListener listener)
            {
                _listener = listener;
            }

            public void eventsOccurred(
                com.glympse.android.api.GGlympse glympse,
                int listener,
                int events,
                Java.Lang.Object param)
            {
                _listener.eventsOccurred(
                    (GGlympse)ClassBinder.bind(glympse),
                    listener,
                    events,
                    ClassBinder.bind(param));
            }
        }

        private com.glympse.android.api.GEventSink _raw;

        private Dictionary<GEventListener, ListenerWrapper> _wrappers;

        public EventSink(com.glympse.android.api.GEventSink raw)
        {
            _raw = raw;
            _wrappers = new Dictionary<GEventListener, ListenerWrapper>();
        }

        public bool addListener(GEventListener listener)
        {
            ListenerWrapper wrapper = new ListenerWrapper(listener);
            bool result = _raw.addListener(wrapper);
            if (result)
            {
                _wrappers[listener] = wrapper;
            }
            return result;
        }

        public bool removeListener(GEventListener listener)
        {
            bool result = false;
            if (_wrappers.ContainsKey(listener))
            {
                ListenerWrapper wrapper = _wrappers[listener];
                result = _raw.removeListener(wrapper);
                _wrappers.Remove(listener);
            }
            return result;
        }
    }
}

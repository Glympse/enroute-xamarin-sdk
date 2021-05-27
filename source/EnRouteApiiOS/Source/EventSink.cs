using System;
using System.Collections.Generic;

namespace Glympse.EnRoute.iOS
{
    public class EventSink
    {
        public class ListenerWrapper : GlyEventListener
        {
            private GEventListener _listener;

            public ListenerWrapper(GEventListener listener)
            {
                _listener = listener;
            }

            public void eventsOccurred(
                GlyGlympse glympse,
                int listener,
                int events,
                GlyCommon param)
            {
                _listener.eventsOccurred(
                    (GGlympse)ClassBinder.bind(glympse),
                    listener,
                    events,
                    ClassBinder.bind(param));
            }
        }

        public interface GGlyEventSink
        {
            bool addListener(GlyEventListener listener);

            bool removeListener(GlyEventListener listener);
        }

        private GGlyEventSink _raw;

        private Dictionary<GEventListener, ListenerWrapper> _wrappers;

        public EventSink(GGlyEventSink raw)
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

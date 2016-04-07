using System;
using System.Collections.Generic;
using Glympse.Toolbox;

namespace Glympse.EnRoute.iOS
{
    public class CommonSource
    {
        public class ListenerWrapper : GlyListener
        {
            private GListener _listener;            

            public ListenerWrapper(GListener listener)
            {
                _listener = listener;
            }

            public override void eventsOccurred(
                GlySource source, 
                int listener, 
                int events, 
                GlyCommon param1, 
                GlyCommon param2)
            {
                _listener.eventsOccurred(
                    (GSource)ClassBinder.bind(source), 
                    listener, 
                    events, 
                    ClassBinder.bind(param1), 
                    ClassBinder.bind(param2));
            }
        }

        public interface GGlySource
        {
            bool addListener(GlyListener listener);

            bool removeListener(GlyListener listener);
        }

        private GGlySource _raw;

        private Dictionary<GListener, ListenerWrapper> _wrappers;

        public CommonSource(GGlySource raw)
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

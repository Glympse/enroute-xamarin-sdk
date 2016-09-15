extern alias GlympseApiToolboxDll;

using System.Collections.Generic;
using Glympse.Toolbox;

namespace Glympse.EnRoute.UWP
{
    public class CommonSource
    {
        public class ListenerWrapper : GlympseApiToolboxDll::Glympse.GListener
        {
            private GListener _listener; 

            public ListenerWrapper(GListener listener)
            {
                _listener = listener;
            }

            public void eventsOccurred(GlympseApiToolboxDll::Glympse.GSource source, int listener, int events, object param1, object param2)
            {
                _listener.eventsOccurred((GSource)ClassBinder.bind(source), listener, events, param1, param2);
            }
        }

        private GlympseApiToolboxDll::Glympse.GSource _raw;

        private Dictionary<GListener, ListenerWrapper> _wrappers;

        public CommonSource(GlympseApiToolboxDll::Glympse.GSource raw)
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

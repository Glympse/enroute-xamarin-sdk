namespace Glympse.EnRoute.iOS;

public class EventSink
{
    public class ListenerWrapper : GlyEventListener
    {
        GEventListener _listener;

        public ListenerWrapper(GEventListener listener) =>
            _listener = listener;

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

    GGlyEventSink _raw;

    Dictionary<GEventListener, ListenerWrapper> _wrappers;

    public EventSink(GGlyEventSink raw)
    {
        _raw = raw;
        _wrappers = new Dictionary<GEventListener, ListenerWrapper>();
    }

    public bool addListener(GEventListener listener)
    {
        var wrapper = new ListenerWrapper(listener);
        var result = _raw.addListener(wrapper);
        if (result)
        {
            _wrappers[listener] = wrapper;
        }
        return result;
    }

    public bool removeListener(GEventListener listener)
    {
        var result = false;
        
        if (!_wrappers.ContainsKey(listener))
        {
            return result;
        }

        var wrapper = _wrappers[listener];
        result = _raw.removeListener(wrapper);
        _wrappers.Remove(listener);
        
        return result;
    }
}
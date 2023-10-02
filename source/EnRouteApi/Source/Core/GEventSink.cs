namespace Glympse;

public interface GEventSink : GCommon
{
    bool addListener(GEventListener eventListener);

    bool removeListener(GEventListener eventListener);
}
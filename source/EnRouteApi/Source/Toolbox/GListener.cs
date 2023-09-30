namespace Glympse.Toolbox;

public interface GListener
{
    void eventsOccurred(GSource source, int listener, int events, object param1, object param2);
}
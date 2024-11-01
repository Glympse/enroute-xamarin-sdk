namespace Glympse
{
    public interface GList<T> : GCommon, IEnumerable<T>
    {
        int length();

        T getFirst();

        T getLast();
    }
}

namespace Glympse;

public interface GArray<out T> : GCommon, IEnumerable<T>
{
    int length();

    T at(int index);
}
using System.Collections;

namespace Glympse.EnRoute.iOS;

public class Array<T> : GArray<T>
{
    GlyArray _raw;       

    public Array(GlyArray array) =>
        _raw = array;

    public int length() =>
        _raw.count();

    public T at(int index) =>
        (T)ClassBinder.bind(_raw.objectAtIndex(index));

    public IEnumerator<T> GetEnumerator() =>
        new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() =>
        new Enumerator(this);

    public object raw() =>
        _raw;

    class Enumerator : IEnumerator<T>
    {
        Array<T> _array;

        int _index;

        public Enumerator(Array<T> array)
        {
            _array = array;
            _index = 0;
        }

        public T Current =>
            _array.at(_index);

        object IEnumerator.Current =>
            _array.at(_index);

        public bool MoveNext()
        {
            ++_index;
            return _index < _array.length();
        }

        public void Reset()
        {
            _index = 0;
        }

        public void Dispose()
        {
            _array = null;
        }                        
    }
}
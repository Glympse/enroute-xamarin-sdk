using System.Collections;

namespace Glympse.EnRoute.Android
{
    public class List<T> : GList<T>
    {
        private com.glympse.android.core.GList _raw;       

        public List(com.glympse.android.core.GList list)
        {
            _raw = list;        
        }

        public int length()
        {
            return _raw.length();
        }

        public T getFirst()
        {
          return (T)ClassBinder.bind(_raw.getFirst());
        }

        public T getLast()
        {
          return (T)ClassBinder.bind(_raw.getLast());
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(_raw.elements()); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(_raw.elements()); 
        }

        public object raw()
        {
            return _raw;
        }

        private class Enumerator : IEnumerator<T>
        {
            private Java.Util.IEnumeration _enumeration;
            private Java.Lang.Object _currentElement;

            public Enumerator(Java.Util.IEnumeration enumeration)
            {
                _enumeration = enumeration;
            }

            public T Current 
            { 
                get
                {
                    return (T)ClassBinder.bind(_currentElement);
                }
            }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                _currentElement = default;
                if (_enumeration.HasMoreElements)
                {
                    _currentElement = _enumeration.NextElement();
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                // Not supported? Maybe move to get first or something
            }

            public void Dispose()
            {
                _enumeration = null;
                _currentElement = default;
            }         
        }
    }
}

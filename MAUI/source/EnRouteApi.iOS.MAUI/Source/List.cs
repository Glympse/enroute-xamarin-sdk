using System.Collections;

namespace Glympse.EnRoute.iOS
{
    public class List<T> : GList<T>
    {
        private GlyList _raw;       

        public List(GlyList list)
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
            private GlyEnumeration _enumeration;
            private GlyCommon _currentElement;

            public Enumerator(GlyEnumeration enumeration)
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
                if (_enumeration.hasMoreElements())
                {
                    _currentElement = _enumeration.nextElement();
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

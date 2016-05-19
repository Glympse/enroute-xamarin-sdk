using System;
using System.Collections;
using System.Collections.Generic;

namespace Glympse.EnRoute.iOS
{
    public class Vector<T> : GVector<T>
    {
        private GlyVector _raw;       

        public Vector(GlyVector vector)
        {
            _raw = vector;        
        }

        public int length()
        {
            return _raw.count();
        }

        public T at(int index)
        {
            return (T)ClassBinder.bind(_raw.objectAtIndex(index));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this); 
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new Enumerator(this); 
        }

        public object raw()
        {
            return _raw;
        }

        private class Enumerator : IEnumerator<T>
        {
            private Vector<T> _vector;

            private int _index;

            public Enumerator(Vector<T> vector)
            {
                _vector = vector;
                _index = 0;
            }

            public T Current 
            { 
                get
                {
                    return _vector.at(_index);
                }
            }

            Object System.Collections.IEnumerator.Current 
            { 
                get
                {
                    return _vector.at(_index);
                }
            }  

            public bool MoveNext()
            {
                ++_index;
                return ( _index < _vector.length() );
            }

            public void Reset()
            {
                _index = 0;
            }

            public void Dispose()
            {
                _vector = null;
            }                        
        }
    }
}


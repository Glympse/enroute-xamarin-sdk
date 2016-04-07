using System;
using Glympse.EnRoute;

namespace EnRouteDemo
{
    /**
     * Wraps EnRoute SDK for the purpose of accessing from various application components. 
     */ 
    public class Wrapper
    {
        private Wrapper _wrapper;        

        private Wrapper()
        {
        }

        public static Wrapper instance()
        {
            if ( null == _wrapper ) 
            {
                _wrapper = new Wrapper ();
            }    
            return _wrapper;
        }

        public Wrapper ()
        {
        }
    }
}

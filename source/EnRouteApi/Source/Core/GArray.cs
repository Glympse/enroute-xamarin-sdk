using System;
using System.Collections.Generic;

namespace Glympse
{
    public interface GArray<T> : GCommon, IEnumerable<T>
    {
        int length();

        T at(int index);
    }
}

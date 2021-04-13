using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_List
{
    public interface Iterator<T>
    {
        bool hasNext();
        T next();
    }
}

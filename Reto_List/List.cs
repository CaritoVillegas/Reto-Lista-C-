using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_List
{
    public interface List<T>
    {
        void add(T data);
        T get(int index);
        void delate(int index);
        int getSize();
        Iterator<T> getReverseIterator();
        Iterator<T> getIterator();

    }
}

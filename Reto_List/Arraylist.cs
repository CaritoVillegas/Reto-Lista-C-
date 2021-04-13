using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_List
{
    public class Arraylist<H> : List<H>
    {
        private Object[] array;
        private int size;

        public void ArrayList()
        {
            this.array = new Object[10];
        }

        public void add(H data) //add de sam uwu
        {
            if (size >= array.Length)
            {
                Object[] arrayN = new Object[array.Length + 2];
                for (int i = 0; i < array.Length; i++)
                {
                    arrayN[i] = array[i];
                }
                this.array = arrayN;

            }
            this.array[size] = data;
            size++;
        }

        public H get(int index)
        {
            return (H)array[index];
        }

        public void delate(int index)
        {

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;

        }
        public int getSize()
        {

            return size;
        }


        public Iterator<H> getIterator()
        {
            return new ForwardIterator();
        }



        public Iterator<H> getReverseIterator()
        {
            return new ReverseIterator();
        }

        public class ForwardIterator : Iterator<H>
        {

            private int current;
            private Arraylist<H> arraylist;
            public ForwardIterator() { 
                this.current = 0; 
            }
            public ForwardIterator(Arraylist<H> arraylist)
            {
                this.arraylist = arraylist;
                this.current = 0;
            }

            public bool hasNext() { return current < arraylist.size; }


            public H next()
            {
                H data = (H)arraylist.array[current];
                current++;
                return data;
            }
        }

        public class ReverseIterator : Iterator<H>
        {
            private int current;
            private Arraylist<H> arraylist;
            public ReverseIterator()
            {
                this.current = arraylist.size - 1;
            }


            public bool hasNext()
            {
                return current >= 0;
            }


            public H next()
            {
                H data = (H)arraylist.array[current];
                current--;
                return data;
            }
        }
    }
}

    




 
   
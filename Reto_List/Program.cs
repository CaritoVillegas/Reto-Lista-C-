using System;

namespace Reto_List
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> lista1 = new LinkedList<int>();
            List<string> lista2 = new LinkedList<string>();
            List<string> lista3 = new LinkedList<string>();


            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);
            lista1.add(5);
            lista1.add(9);

            lista2.add("hola");
            lista2.add("Ayer");
            lista2.add("comi");
            lista2.add("posho");
            lista2.add("holiwiz");

            lista3.add("dale");
            lista3.add("A");
            lista3.add("Tu");
            lista3.add("cuerpo");
            lista3.add("Alegria");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("El tamaño es: {0}" , lista1.getSize());

            Iterator<int> it = lista1.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: {0}", element);
            }
            lista1.delate(3);
            Console.WriteLine("---------------------");

            it = lista1.getReverseIterator();
            Console.WriteLine("El tamaño es:{0}", lista1.getSize());
            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato:{0} ", element);
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("El tamaño es:{0}", lista2.getSize());
            Iterator<String> itstrings = lista2.getIterator();
            while (itstrings.hasNext())
            {
                Console.WriteLine(itstrings.next());
            }
            Console.WriteLine("---------------------");
            Iterator<String> ituwu = lista3.getIterator();
            Console.WriteLine("El tamaño es:" + lista3.getSize());
            while (ituwu.hasNext())
            {
                String element = ituwu.next();

                Console.WriteLine("Dato:{0} ", element);
            }
            lista3.delate(3);
            Console.WriteLine("---------------------");

            ituwu = lista3.getReverseIterator();
            Console.WriteLine("El tamaño es:{0}", lista3.getSize());
            while (ituwu.hasNext())
            {
                String element = ituwu.next();

                Console.WriteLine("Dato: {0}", element);
            }
        }
    }
  
}

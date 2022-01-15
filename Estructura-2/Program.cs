
namespace Estructuras2
   {
    class Program
    {
        static void mostrarLista(List<int> lista)
        {
            foreach (int x in lista)
            {
                Console.Write(x + " ");

            }
            Console.WriteLine("");
        }
        //Necesitamos una estructura repetitiva para las listas
        /*
         Para cada entero x de la lista vamos a repetir la operacion..
        Cuando va terminar esto?
        cuando se nos agote los enteros
         */
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            lista1.Add(5);
            lista1.Add(7);
            lista1.Add(1);
            lista1.Add(3);
            lista2.Add(5);
            lista2.Add(9);
            lista2.Add(8);
            lista2.Add(6);
            Console.WriteLine("Lista 1" );
            mostrarLista(lista1);
            Console.WriteLine("Lista 2");
            mostrarLista(lista2);
            /*
             Supongamos que quisieramos agregar en la lista 2 el numero  10 en la posicion 5 
            Con el metodo lista2.Insert() --- Insertar
             */
            lista2.Insert(4, 10);
            mostrarLista(lista2);
           /*
            A continuacion vamos a concatenar dos listas
           AddRange -- AgregarSerie
            */
           List <int>  lista3 = new List<int>(); 
            lista3.AddRange(lista2);
            lista3.AddRange(lista1);
            Console.WriteLine("Lista 3 : ");
            mostrarLista(lista3);
            /*Como podemos buscar elementos en una lista?
             * IndexOf() -- Indice de
             * con  lista.IndexOf(n)
             Ejemplo:
             */

            Console.WriteLine("El 10 esta en la posición " + lista3.IndexOf(10));
            /*
             Hay otra forma de buscar con BinarySearch() -- BusquedaBinaria
             */

            /*
             Console.WriteLine(lista3.BinarySearch(10));
            En este caso no lo encuentra y un numero negativo osea que esta fuera de rango.
            Lo hace porque primero para utilizar este metodo debe estar ordenado
             */
            /*
             Como ordenar listas?
            Utilizando el metodo .Sort() -- Ordenar
             */
            lista3.Sort();
            Console.WriteLine("Lista 3 ordenada: ");
            mostrarLista(lista3);
            Console.WriteLine(lista3.BinarySearch(10));

        }
    }
   }
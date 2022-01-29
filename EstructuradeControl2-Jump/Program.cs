

namespace Estructuras2
{
    class Program
    {
        static void mostrarLista(List<int> v)
        {
            foreach (int x in v)
            {
                //Con salto, continue
                /*
                 *  if(x % 2 != 0)
                {
                    continue
                }
                Console.Write(x + "");
                 */
                //Sin salto 
                if (x % 2 == 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine("");

        }
        static void buscarNum(int x, List<int> v)
        {
            /*
             Lo que haremos es : 
            1utilizaremos un indice que va pasar por la lista 
            2comparar cada numero que saquemos de la lista con el numero que nos pasaron como parametros
             */
            bool encontrado = false;
            for (int i = 0; i < v.Count && !encontrado; i++)
            {
                /*
              * Sin break
                if (v[i] == x)
                {
                    Console.WriteLine("El numero : " + x + "esta en la lista");
                }
                Console.Write(i + " ");
                
                */
                //Con break para que no nos siga mostrando los numeros de la lista,
                //y Cuando encuentre el numero salte el ciclo y siga con las instrucciones que le siguen
                if (v[i] == x)
                {
                    Console.WriteLine("El numero : " + x + " esta en la lista");
                    encontrado = true;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            for (int i = 1; i <= 40; i++)
            {
                lista.Add(i);
            }
            mostrarLista(lista);
            buscarNum(5, lista);
            int ind = 0;
            //En este caso el incremento no se ejecuta nunca y estamos en un loop infinito
            // Por lo tanto la condicion se mantiene todo el tiempo verdadera
            while (ind < 40)
            {
                if(lista[ind]!=6)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("El numero 6 esta en la lista");
                }
                ind++;
            }

        }
    }
}

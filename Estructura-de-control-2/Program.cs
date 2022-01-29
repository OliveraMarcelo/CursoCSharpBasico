

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
                if(x % 2 == 0)
                {
                    Console.Write(x + "");
                }
                Console.WriteLine("");
            }
        }
        static void buscarNum(int x , List<int> v)
        {
            /*
             Lo que haremos es : 
            1utilizaremos un indice que va pasar por la lista 
            2comparar cada numero que saquemos de la lista con el numero que nos pasaron como parametros
             */
            for(int i = 0 ; i < v.Count ; i++)
            {
                if(v[i] == x)
                    Console.Writeline("El numero : " + x + "esta en la lista");
                Console.Write(i + " ");
            }
            Console.WriteLine("")
        }
        static void Main(sting[] args)
        {
            List<int> lista = new List<int>(); 
            for(int i = 1;i<=40;i++)
            {
                lista.Add(i);
            }
            mostrarLista(lista); 
            buscarNum(40,lista);
        }
    }
}

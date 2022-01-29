

namespace Estructuras3
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] vector = { 1, 2, 3 , 4 ,5 };
            for(int i = 0; i <= vector.Length; i++)
            {
                try
                {
                Console.WriteLine(vector[i]);
                }
                catch (Exception ex) //Conviene ser mas especifico entonces cambiamos a que puede ser nu error de INDEXOUTOFRANGEEXCEPTION
                {
                    Console.WriteLine("Nos pasamos de rango, valor del indice " + i);  
                }
                finally //Finally sirve para ejecutando texto
                {}

            }
            Console.Write("[");
            for(int i = 0 ; i < vector.Length ; i++)
            {
                Console.Write (vector[i]);
                if(i < vector.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");

        }
    }
}
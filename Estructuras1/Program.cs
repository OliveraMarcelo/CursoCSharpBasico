
namespace Estructura1
{
    class Program
    {
        static void mostrarVector(int[] v)
        {
            Console.Write("[");

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.Write("]");

            Console.WriteLine("");
        }

        static double promedio(int[] vector1)
        {
            int suma=0;

            for (int i = 0; i < vector1.Length; i++)
            {
                 suma += vector1[i];
            }
            int largo = vector1.Length;
            int promedio = suma / largo;
            return promedio;

        }
        static void mostrarMatriz(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3, 4, 5, 6, };
            int[,] matriz = new int[4, 5]; // declaramos primero las filas y despues las columnas
            mostrarVector(vector);
            Console.WriteLine("El maximo elemento es " + vector.Max() + " y el minimo es  " + vector.Min());
            Console.WriteLine("El promedio es " + vector.Average());
            mostrarMatriz(matriz);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = (i + j) % 10;
                }
                Console.WriteLine("");
            }
            //Ejercicio
            int prov = vector[0];
            for(int i = 0; i < vector.Length - 1 ; i++)
            {
                vector[i] = vector[i + 1];
               
            }
            vector[vector.Length - 1] = prov;
            // vector[0] = 1
            //vector[9] = 1
            //--- vector[9] = 1
            // int [] vector = {}
            Console.WriteLine("Resultado: ");
            promedio(vector);

            mostrarVector(vector);
        }
    }

}
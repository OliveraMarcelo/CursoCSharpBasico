
using System;
using System.Collections.Generic;


namespace EstructurasDeDatos3
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
        static bool esPar(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            /* Ya tenemos nuestra lista del 1 al 20*/
            for(int i = 1;i <= 20; i++)
            {
                lista1.Add(i);
            }
            Console.Write("Lista 1 : ");
            mostrarLista(lista1);
            //Removemos todos los elementos que cumplen el predicado
            lista1.RemoveAll(esPar);
            Console.Write("Lista 1 : ");
            mostrarLista(lista1);
            //
            List<int> Ej01 = new List<int>();
            List<int> Ej02 = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                if( i <= 9 )
                {
                    Ej01.Add(i);
                }
                if(i>=6)
                {
                    Ej02.Add(i);
                }
            }
            Console.Write("EJ01 : ");
            mostrarLista(Ej01);
            Console.Write("EJ02 : ");
            mostrarLista(Ej02);
            // Como calculamos la interseccion?
            /*
             1. Creamos una nueva lista para que contengan los numeros que son la interseccion de las listas
             2. Recorremos cada elemento de la lista EJ02 
             3. Preguntamos si cada elemento de la lista EJ01 contiene x 
             4. La agregamos a la nueva lista que creamos
             */
            List<int> inter = new List<int>();
            foreach(int x in Ej02)
            {
                if(Ej01.Contains(x))
                {
                    inter.Add(x);
                }
            }
            Console.Write("Interseccion : ");
            mostrarLista(inter);
        }
    }
}
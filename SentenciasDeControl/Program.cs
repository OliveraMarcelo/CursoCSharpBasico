namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[]args)
        {
            List<int> lista = new List<int> ();
            lista.Add(30);
            lista.Add(27);
            lista.Add(20);
            lista.Add(17);
            lista.Add(5);
            foreach(int x in lista)
            {
                if(x % 3 == 0)
                {
                    if(x % 2 == 0)
                    {
                        Console.WriteLine("El numero : " + x + " es divisible por seis");
                    }
                    else
                    {
                        Console.WriteLine("El numero : " + x + " es divisible por tres");
                    }

                }
                else if(x % 2 == 0 )
                {
                    Console.WriteLine("El numero : " + x + " es divisible por dos");
                }
                else
                {
                    Console.WriteLine("El numero : " + x + " no es divisible por tres ni por dos");
                }
            }
        }
    }
}
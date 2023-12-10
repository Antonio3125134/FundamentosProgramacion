using System;

namespace Programa6U5
{
    internal class Programa6U5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud de la secuencia Fibonacci: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Secuencia Fibonacci:");
            for (int i = 0; i < longitud; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
        


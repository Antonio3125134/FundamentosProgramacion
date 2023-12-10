using System;

namespace Programa4U5
{
    internal class Programa4U5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para verificar si es primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine(numero + " es un número primo.");
            }
            else
            {
                Console.WriteLine(numero + " no es un número primo.");
            }
        }

        static bool EsPrimo(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
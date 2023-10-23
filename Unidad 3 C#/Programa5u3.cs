using System;

namespace Programa5u3
{
    class Programa5u3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " es par");
            }
            else
            {
                Console.WriteLine(numero + " es impar");
            }
        }
    }
}
    


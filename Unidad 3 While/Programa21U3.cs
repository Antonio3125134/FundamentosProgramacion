using System;

namespace Programa21U3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeros naturales: ");
            int cn = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= cn)
            {
                Console.Write("Ingrese el numero " + i + ": ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    int cubo = numero * numero * numero;
                    Console.WriteLine("El cubo de " + numero + " es: " + cubo);
                    i++;
                }
                else
                {
                    Console.WriteLine("Ingrese un numero natural positivo.");
                }
            }
        }
    }
}
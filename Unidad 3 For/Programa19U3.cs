using System;

namespace Programa19U3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa la cantidad de números: ");
            int Cn = Convert.ToInt32(Console.ReadLine());
            int Cc = 0;
            int Cmc = 0;
            int Cmec = 0;

            for (int i = 0; i < Cn; i++)
            {
                Console.Write("Ingresa el número " + (i + 1) + ": ");
                double N = Convert.ToDouble(Console.ReadLine());

                if (N == 0)
                {
                    Cc++;
                }
                else if (N > 0)
                {
                    Cmc++;
                }
                else
                {
                    Cmec++;
                }
            }

            Console.WriteLine("Cantidad de números iguales a cero: " + Cc);
            Console.WriteLine("Cantidad de números mayores a cero: " + Cmc);
            Console.WriteLine("Cantidad de números menores a cero: " + Cmec);
        }
    }
}
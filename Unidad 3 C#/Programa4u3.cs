using System;

namespace Programa4u3
{
    class Programa4u3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el valor de p1: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el valor de p2: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el valor de p3: ");
            double p3 = Convert.ToDouble(Console.ReadLine());

            double total = p1 + p2 + p3;
            if (total <= 1500)
            {
                total = total - (total * 0.30);
                Console.WriteLine("Mostrar el total (30% descuento): " + total);
            }
            else if (total < 1500 && total >= 1000)
            {
                Console.WriteLine("El total (20% descuento): " + total);
            }
            else if (total < 1000 && total >= 700)
            {
                total = total - (total * 0.10);
                Console.WriteLine("El total (10% descuento): " + total);
            }
            else
            {
                Console.WriteLine("El total (sin descuento): " + total);
            }
        }
    }
}


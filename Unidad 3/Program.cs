using System;

namespace Programa5
{
    internal class Programa5
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, total;
            Console.WriteLine("Escribe el precio 1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el precio 2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el precio 3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            total = p1 + p2 + p3;
            if (total >= 1500)
            {
                total = total - (total * 0.30);
                Console.WriteLine("El total es (30% desc): " + total);
            }
            else if (total < 1500 && total >= 1000)
            {
                total = total - (total * 0.20);
                Console.WriteLine("El total es (20% desc): " + total);
            }
            else if (total < 1000 && total >= 700)
            {
                total = total - (total * 0.10);
                Console.WriteLine("El total es (10% desc): " + total);
            }
            else
            {
                Console.WriteLine("El total es (sin desc): " + total);
            }
        }
    }
}

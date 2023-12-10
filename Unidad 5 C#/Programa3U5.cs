using System;

namespace Programa3U5
{
    internal class Programa3U5
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Escriba el valor de X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Resultado de la ecuacion 1: " + Ecuacion1(x, y));
            Console.WriteLine("Resultado de la ecuacion 2: " + Ecuacion2(x, y));
        }

        public static double Ecuacion1(double x, double y)
        {
            double r;
            r = Math.Pow(x, 2) + (2 * Math.Pow(y, 4));
            return r;
        }

        public static double Ecuacion2(double x, double y)
        {
            double r;
            r = Math.Sqrt(Math.Pow(x, 4) + 5 * y);
            return r;
        }
    }
}

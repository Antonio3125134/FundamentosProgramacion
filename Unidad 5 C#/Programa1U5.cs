using System;

namespace Programa1U4
{
    internal class Programa1U4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma =" + Suma(7, 8));
            Console.WriteLine("Resta =" + Resta(7, 8));
            Console.WriteLine("Multiplicacion =" + Multiplicacion(7, 8));
            Console.WriteLine("Division =" + Division(7, 8));
        }

        public static int Suma(int a, int b)
        {
            int r = a + b;
            return r;
        }

        public static int Resta(int a, int b)
        {
            int r = a - b;
            return r;
        }

        public static int Multiplicacion(int a, int b)
        {
            int r = a * b;
            return r;
        }

        public static int Division(int a, int b)
        {
            int r = a / b;
            return r;
        }
    }
}

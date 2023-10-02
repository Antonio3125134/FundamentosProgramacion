using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int Y, A, X;
            Console.WriteLine("ingresar valor de Y");
            Y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingresar valor de A");
            A = Int32.Parse(Console.ReadLine());

            X = Y + A + 3;
            Console.WriteLine("El resultado de la formula es:" + X);

        }
    }
}

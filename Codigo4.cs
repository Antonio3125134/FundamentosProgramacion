using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa4
    {
        static void Main(string[] args)
        {
            int C, F;
            Console.WriteLine("ingresa el valor en grados celsius");
            C = Int32.Parse(Console.ReadLine());

            F = C * 9 / 5 + 32;
            Console.WriteLine("Mostrar el resultado en fahrenheit:" + F);
        }
             





    }
}
using System;

namespace programa5 // Note: actual namespace depends on the project name.
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("metro:");
            double metro = double.Parse(Console.ReadLine());
            double convertir = metro * 3.28084;
            Console.Write($"{convertir} ft");
            Console.ReadKey();

        }
    }
}
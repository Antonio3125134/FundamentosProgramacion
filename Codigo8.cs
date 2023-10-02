// See https://aka.ms/new-console-template for more information
using System;



namespace programa8
{

    internal class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lado: ");
            double lado = double.Parse(Console.ReadLine());
            double perimetro = lado * 6;
            Console.WriteLine($"{perimetro} cm");
            Console.ReadKey();

        }
    }
}






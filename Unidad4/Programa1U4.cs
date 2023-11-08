using System;

namespace Programa1U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[] { 17, 19, 18, 18, 17, };

            int[] edades2 = { 17, 19, 18, 18, 18 };

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Indice: " + i + " es: " + edades[i]);
                if (edades[i] >= 18)
                    Console.WriteLine("Eres mayor!!");
                else
                    Console.WriteLine("Eres menor!!");
            }
        }
    }
}
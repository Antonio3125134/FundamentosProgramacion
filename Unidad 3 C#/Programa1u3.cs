using System;

namespace Programa1u3
{
    class Programa1u3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("¡Eres mayor de edad!");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }
    }
}

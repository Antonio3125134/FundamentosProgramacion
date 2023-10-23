using System;

namespace Programa7u3
{
    class Programa7u3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la temperatura: ");
            int T = Convert.ToInt32(Console.ReadLine());

            if (T >= 27)
            {
                Console.WriteLine("¡Hace calor!");
            }
            else if (T > 20 && T <= 27)
            {
                Console.WriteLine("¡El clima es agradable!");
            }
            else if (T < 20)
            {
                Console.WriteLine("¡El clima es frío!");
            }
        }
    }
}

                  
     
                  



     
using System;

namespace Programa8u5
{
    internal class Programa8U5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de veces que desea lanzar el dado: ");
            int vecesLanzamiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultados de los lanzamientos:");

            for (int i = 0; i < vecesLanzamiento; i++)
            {
                int resultado = LanzarDado();
                Console.WriteLine("Lanzamiento " + (i + 1) + ": " + resultado);
            }
        }

        static int LanzarDado()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}

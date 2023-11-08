using System;

namespace Programa2U4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = new int[] { 100, 80, 95, 72, 34, 32, 78, 44, 67, 29 };
            int suma = 0, promedio=0;
            

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("Calif: " + i + " es: " + calificaciones[i]);
                suma += calificaciones[i];

                promedio = suma / calificaciones.Length;
            }
            Console.WriteLine("El promedio es: " +promedio);
        }
    }
}
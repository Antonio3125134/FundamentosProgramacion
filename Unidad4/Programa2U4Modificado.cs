using System;

namespace Programa2U4Modificado
{
    internal class Programa2U4
    {
        static void Main(string[] args)
        {
            int suma = 0, prom = 0, tam;

            Console.WriteLine("Escribe las calificaciones a procesar: ");
            tam = Convert.ToInt32(Console.ReadLine());
            int[] calificaciones = new int[tam];
            //Solicitar valores
            for (int c = 0; c < calificaciones.Length; c++)
            {
                Console.WriteLine("Escribe calificación en el indice 0: ");
                calificaciones[c] = Convert.ToInt32(Console.ReadLine());
            }

                for (int i = 0; i < calificaciones.Length; i++)
            {
                
                suma = suma + calificaciones[i];

                prom = suma / calificaciones.Length;
            }
            Console.WriteLine("La suma de las calificaciones es: " + suma);
            Console.WriteLine("El promedio es: " + prom);
        }
    }
}
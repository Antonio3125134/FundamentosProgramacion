using System;

namespace Programa2u3
{
    class Programa2u3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primera calificación: ");
            double ca1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda calificación: ");
            double cal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera calificación: ");
            double cal3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cuarta calificación: ");
            double ca4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la quinta calificación: ");
            double cal5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la sexta calificación: ");
            double cal6 = Convert.ToDouble(Console.ReadLine());

            double suma = ca1 + cal2 + cal3 + ca4 + cal5 + cal6;
            double promedio = suma / 6;

            if (promedio <= 70)
            {
                Console.WriteLine("El alumno está aprobado");
            }
            else
            {
                Console.WriteLine("El alumno está reprobado");
            }
        }
    }
}
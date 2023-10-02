using System;

namespace programa3
{
    internal class Promedio
    {
        static void Main(string[] args)
        {
            int c1, c2, c3, c4, c5, c6;
            float promedio;
            Console.WriteLine("escribe tu primera calificacion");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe tu segunda calificacion");
            c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe tu tercera calificacion");
            c3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe tu cuarta calificacion");
            c4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe tu quinta calificacion");
            c5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe tu sexta calificacion");
            c6 = Convert.ToInt32(Console.ReadLine());
            promedio = c1 + c2 + c3 + c4 + c5 + c6 / 6;
            Console.WriteLine("Tu promedio es:" + promedio);

        }
    }
}

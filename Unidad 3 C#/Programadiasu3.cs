using System;

namespace Programadiasu3
{
    class Programadiasu3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el número de la semana:");
            int Dias = Convert.ToInt32(Console.ReadLine());

            switch (Dias)
            {
                case 1:
                    Console.WriteLine("lunes");
                    break;
                case 2:
                    Console.WriteLine("martes");
                    break;
                case 3:
                    Console.WriteLine("miércoles");
                    break;
                case 4:
                    Console.WriteLine("jueves");
                    break;
                case 5:
                    Console.WriteLine("viernes");
                    break;
                case 6:
                    Console.WriteLine("sábado");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;
                default:
                    Console.WriteLine("No existe el día ingresado.");
                    break;
            }
        }
    }
}
      
                  

   
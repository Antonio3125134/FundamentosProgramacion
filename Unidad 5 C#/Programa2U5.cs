using System;

namespace Programa2U5
{
    internal class Programa2U5
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Elige el tipo de conversion a realizar: ");
            Console.WriteLine("1. Temperatura °C a °F");
            Console.WriteLine("2. Temperatura °F a °K");
            Console.WriteLine("3. Medida pulgadas a metros");
            Console.WriteLine("4. Tiempo horas a segundos");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    int c;
                    Console.Write("Escribe los °C a convertir: ");
                    c= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tu resultado es: " + temperaturaCF(c));
                    break;
                case 2:
                    Console.WriteLine("Tu resultado es: "+temperaturaFK());
                    break;
                case 3:
                    Medida();
                    break;
                case 4:
                    Console.WriteLine(tiempo());
                    break;
                default: 
                    Console.WriteLine("La opción es incorrecta");
                    break;
            }//FIN SWITCH
        }//FIN MAIN
        public static double temperaturaCF(double c)
        {
            double resultado = (c * 1.8) + 32;
            return resultado;
        }
        public static double temperaturaFK()
        {
            double F, resultado;
            Console.Write("Escribe la temperatura °F a convertir: ");
            F= Convert.ToDouble(Console.ReadLine());
            resultado = (F - 32) * (5 / 9) + 273.15;
            return resultado;
        }
        public static void Medida()
        {
            double p, resultado;
            Console.Write("Escribe la medida en pulgadas: ");
            p= Convert.ToDouble(Console.ReadLine());
            resultado = p / 39.37;
            Console.WriteLine("Tu resultado es: " + resultado);

        }
        public static double tiempo()
        {
            double h;
            Console.Write("Escribe las horas a convertir: ");
            h = Convert.ToDouble(Console.ReadLine());
            return h * 3600;
        }
    }
}
using System;

namespace programa9u5
{
    internal class Programa9U5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el sueldo diario del trabajador: $");
            double sueldoDiario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tiempo laborado (en días): ");
            int tiempoLaborado = Convert.ToInt32(Console.ReadLine());

            double finiquito = CalcularFiniquito(sueldoDiario, tiempoLaborado);

            Console.WriteLine("Finiquito del trabajador: $" + finiquito);
        }

        static double CalcularFiniquito(double sueldoDiario, int tiempoLaborado)
        {
            return sueldoDiario * tiempoLaborado;
        }
    }
}
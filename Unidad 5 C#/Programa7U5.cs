using System;

namespace programa7u5
{
    internal class Programa7U5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el subtotal: ");
            double subtotal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el IVA: ");
            double tasaIVA = Convert.ToDouble(Console.ReadLine());

            double iva = CalcularIVA(subtotal, tasaIVA);
            double total = CalcularTotal(subtotal, iva);

            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("IVA: " + iva);
            Console.WriteLine("Total: " + total);
        }

        static double CalcularIVA(double subtotal, double tasaIVA)
        {
            return subtotal * (tasaIVA / 100);
        }

        static double CalcularTotal(double subtotal, double iva)
        {
            return subtotal + iva;
        }
    }
}

using System;

namespace Programa18U3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Si = 1500;
            double Ia = 0.10;
            double Sa = Si;

            Console.WriteLine("Salario inicial: $" + Si);

            for (int i = 1; i <= 6; i++)
            {
                double incremento = Sa * Ia;
                Sa += incremento;

                Console.WriteLine("Salario en el año " + i + ": $" + Sa);
            }

            Console.WriteLine("Salario al cabo de 6 años: $" + Sa);
        }
    }
}
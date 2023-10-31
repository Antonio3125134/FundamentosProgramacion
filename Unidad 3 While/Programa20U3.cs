using System;

namespace Programa20U3
{
    class Program
    {
        static void Main(string[] args)
        {
            int DiasAnio = 365;
            double AhorroD = 3.0;
            double AhorroT = 0.0;
            int dia = 1;

            while (dia <= DiasAnio)
            {
                AhorroT += AhorroD;
                Console.WriteLine("Ahorro el día " + dia + ": $" + AhorroD);
                AhorroD *= 3;
                dia++;
            }

            Console.WriteLine("Ahorro total en un año: $" + AhorroT);
        }
    }
}
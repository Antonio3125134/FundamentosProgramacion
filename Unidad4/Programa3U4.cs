using System;

namespace Programa3U4
{
    internal class Programa3U4
    {
        static void Main(string[] args)
        {
            int tam;

            Console.WriteLine("Escribe las temperaturas a procesar: ");
            tam = Convert.ToInt32(Console.ReadLine());
            int[] temp = new int[tam];
            
            for (int c = 0; c < temp.Length; c++)
            {
                Console.WriteLine("Escribe la temperatura "+c+" en Celcius: ");
                temp[c] = Convert.ToInt32(Console.ReadLine());

                double tempf = (temp[c] * 9 / 5) + 32;
                double tempk = temp[c] + 273.15;

                Console.WriteLine("Las temperaturas en Celcius son: " + temp[c] + "°");
                Console.WriteLine("Las temperaturas en Farenheit son: " + tempf + "°");
                Console.WriteLine("Las temperaturas en Kelvin son: " + tempk + "°");
            }     
        }
    }
}
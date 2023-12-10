using System;

namespace Programa5U5
{
    internal class Programa5U5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase para contar las palabras: ");
            string frase = Console.ReadLine();

            int cantidadPalabras = ContarPalabras(frase);
            Console.WriteLine("Número de palabras: " + cantidadPalabras);
        }

        static int ContarPalabras(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return 0;
            }

            string[] palabras = cadena.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
    }
}
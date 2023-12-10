using System;
using System.Text;

namespace programa10u5
{
    internal class Programa10U5
    {
        static void Main(string[] args)
        {
            int longitud = 8;
            string contrasena = GenerarContrasenaAleatoria(longitud);
            Console.WriteLine("Password: " + contrasena);
        }

        public static string GenerarContrasenaAleatoria(int longitud)
        {
            // Declarar los caracteres permitidos
            string caracteres = "ABCDEFghijkl0123456789*-_.";
            Random random = new Random();

            // Construir la cadena de caracteres aleatorios
            StringBuilder cadena = new StringBuilder(longitud);
            for (int i = 0; i < longitud; i++)
            {
                int indiceCaracter = random.Next(caracteres.Length);
                cadena.Append(caracteres[indiceCaracter]);
            }

            return cadena.ToString();
        }
    }
}

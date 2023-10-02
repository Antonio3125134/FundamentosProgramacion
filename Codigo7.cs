using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            do
            {
                int valor1 = 0; // aqui se almacenara el primer valor ingresado.

                int valor2 = 0; // aqui se almacenara el segundo valor ingresado.

                int R = 0; // aqui se almacena el resultado de la operacion.



                //aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu se seleccion.

                Console.WriteLine(" presiona el simbolo para realizar la operacion:n");

                Console.WriteLine("+ para sumar");

                Console.WriteLine("- para restar");

                Console.WriteLine("* para multiplicar");

                Console.WriteLine("/ para dividir");

                Console.WriteLine("n elija una opcion: "); // aqui es donde indicaremos que operacion se realizaran.

                resp = Console.ReadLine();
                
                string eleccion = Convert.ToString(resp);
               
                // aqui se egregara los mensajes para poder ingresar los datos.

                Console.WriteLine("ingrese sus dos numeros");

                Console.WriteLine("valor1:");

                valor1 = int.Parse(Console.ReadLine());

                Console.Write("valor2: ");

                valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine();



                switch (eleccion)

                {
                    case "+":
                        Console.WriteLine("el resultado de la suma es:");

                        R = valor1 + valor2;

                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);

                        break;

                    case "-":


                        Console.WriteLine("el resultado de la resta es:");

                        R = valor1 - valor2;

                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);

                        break;

                    case "*":
                        Console.WriteLine("el resultado de la multiplicacion es:");

                        R = valor1 * valor2;

                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);

                        break;

                    case "/":
                        Console.WriteLine("el resultado de la Division es:");

                        R = valor1 / valor2;

                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);

                        break;
                }
                Console.Write("n¿desea continuar? s/n: "); // si para realizarlo de nuevo y no para salir.

                resp = Console.ReadLine();

            }
            while (resp == "s" || resp == "s");

        }
    }
}
























                
    


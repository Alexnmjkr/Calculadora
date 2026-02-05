using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;

            while (true)
            {
                Console.WriteLine("=== Calculadora Sencilla ===");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Dividir");
                Console.WriteLine("4. Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ha seleccionado Sumar");
                        Console.WriteLine();
                        Console.WriteLine("Ingresa los números");
                        Console.Write("Número 1: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.Write("Resultado: ");
                        Console.WriteLine(numero1 + numero2);
                        Console.WriteLine();
                        Console.WriteLine("Selecciona cualquier tecla para regresar a menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Ha seleccionado Restar");
                        Console.WriteLine();
                        Console.WriteLine("Ingresa los números");
                        Console.Write("Número 1: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.Write("Resultado: ");
                        Console.WriteLine(numero1 - numero2);
                        Console.WriteLine();
                        Console.WriteLine("Selecciona cualquier tecla para regresar a menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Ha seleccionado Dividir");
                        Console.WriteLine();
                        Console.WriteLine("Ingresa los números");
                        Console.Write("Número 1: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.Write("Número 2: ");
                        numero2 = int.Parse(Console.ReadLine());

                        if (numero2 == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        else
                        {
                            Console.Write("Resultado: ");
                            Console.WriteLine((double)numero1 / numero2);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Selecciona cualquier tecla para regresar a menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Console.WriteLine("Saliendo de la calculadora.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

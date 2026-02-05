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

                if (opcion == "4")
                {
                    Console.WriteLine("Saliendo de la calculadora :)");
                    break;
                }

                Console.WriteLine("Número 1: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Número 2: ");
                numero2 = int.Parse(Console.ReadLine());

                Operacion operacion = null;

                switch (opcion)
                {
                    case "1":
                        operacion = new Suma(numero1, numero2);
                        break;

                    case "2":
                        operacion = new Resta(numero1, numero2);
                        break;

                    case "3":
                        operacion = new División(numero1, numero2);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                }
                        Console.WriteLine();
                        Console.WriteLine("Resultado: " + operacion.Calcular());
                        Console.WriteLine();
                        Console.WriteLine("Presiona cualquier tecla para volver al menú");
                        Console.ReadKey(); 
                        Console.Clear();
                
            }
        }
    }
}

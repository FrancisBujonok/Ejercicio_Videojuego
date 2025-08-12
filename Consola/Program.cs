using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RPG Clásico";
            {
                Console.Clear();
                Console.WriteLine("-- RPG Clásico --\n");
                Console.WriteLine("1. Registrar nuevo personaje");
                Console.WriteLine("2. Ver personajes");
                Console.WriteLine("3. Iniciar combate");
                Console.WriteLine("4. Ver historial combates");
                Console.WriteLine("5. Ver estadísticas globales");
                Console.WriteLine("6. Salir");

                Console.Write("Elige una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write($"Ingrese el nombre del personaje:");
                        string nombre = Console.ReadLine();
                        Console.Write($"Ingrese el nivel del personaje:");
                        int nivel = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Seleccione la clase del personaje:");
                        Console.WriteLine("1. Guerrero");
                        Console.WriteLine("2. Mago");
                        Console.WriteLine("3. Arquero");
                        Console.Write("Elige una clase (1-3): ");
                        int clase = int.Parse(Console.ReadLine());

                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 6.");
                        break;
                }

                Console.WriteLine("Fin del programa.");
            }
        }
    }
}

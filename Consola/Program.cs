using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RPG Clásico";
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;
            Console.ForegroundColor = ConsoleColor.Blue;
            {
                bool salir = true;
                while (salir == true)
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
                Gestor_Personaje gestorpersonaje = new Gestor_Personaje();
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
                            if (opcion == 1)
                            {
                                Console.WriteLine("Ingrese el nombre del personaje:");
                                string NombreGuerrero = Console.ReadLine();

                                Console.WriteLine("Ingrese el nivel del personaje:");
                                int NivelGuerrero = int.Parse(Console.ReadLine());

                                Personajes Guerrero = new Guerrero(NombreGuerrero, NivelGuerrero);
                                gestorpersonaje.RegistrarPersonaje(Guerrero);
                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Ingrese el nombre del personaje:");
                                string NombreMago = Console.ReadLine();

                                Console.WriteLine("Ingrese el nivel del personaje:");
                                int NivelMago = int.Parse(Console.ReadLine());

                                Personajes Mago = new Mago(NombreMago, NivelMago);
                                gestorpersonaje.RegistrarPersonaje(Mago);
                            }
                            else if (opcion == 3)
                            {
                                Console.WriteLine("Ingrese el nombre del personaje:");
                                string NombreArquero = Console.ReadLine();

                                Console.WriteLine("Ingrese el nivel del personaje:");
                                int NivelArquero = int.Parse(Console.ReadLine());

                                Personajes Arquero = new Arquero(NombreArquero, NivelArquero);
                                gestorpersonaje.RegistrarPersonaje(Arquero);
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 3.");
                            }


                                break;

                    case 2:
                        gestorpersonaje.VerPersonaje();
                        break;

                    case 3:
                        
                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:
                            salir = false;
                            break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 6.");
                        break;
                    }
                }

                Console.WriteLine("Fin del programa.");
                Console.ReadKey();
            }
        }
    }
}

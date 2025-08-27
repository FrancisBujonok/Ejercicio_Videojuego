using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Gestor_Personaje
    {
        public List<Personajes> Personaje { get; set; }
        public List<Combate> Combate { get; set; }

        public Gestor_Personaje()
        {
            this.Personaje = new List<Personajes>();
            this.Combate = new List<Combate>();
        }
        public void RegistrarPersonaje(Personajes nuevo)
        {
            Console.WriteLine($"Personaje registrado: {nuevo.Nombre}, Nivel: {nuevo.Nivel}, Vida: {nuevo.Vida}, Ataque: {nuevo.Ataque}, Defensa: {nuevo.Defensa}");
            Console.WriteLine("Personaje registrado exitosamente.");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Personaje.Add(nuevo);
        }

        public void VerPersonaje()
        { 
            if (this.Personaje.Count == 0)
            {
                Console.WriteLine("No hay personajes registrados.");
            }
            else
            {
                Console.WriteLine("Lista de personajes registrados:");
                foreach (var personaje in this.Personaje)
                {
                    Console.WriteLine($"- {personaje.Nombre}, Nivel: {personaje.Nivel}, Vida: {personaje.Vida}, Ataque: {personaje.Ataque}, Defensa: {personaje.Defensa}");
                }
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

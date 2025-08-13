using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Personajes
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }

        public Personajes(string nombre, int nivel, int vida, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
        public void RegistrarPersonaje()
        {
            Console.WriteLine($"Personaje registrado: {this.Nombre}, Nivel: {this.Nivel}, Vida: {this.Vida}, Ataque: {this.Ataque}, Defensa: {this.Defensa}");
            this.Personaje.add
        }
        public int RecibirDanio()
        { 
            int danioRecibido = this.Vida - this.Defensa;
            Console.WriteLine($"{this.Nombre} recibe {danioRecibido} puntos de daño.");
            return danioRecibido;
        }
    }
}

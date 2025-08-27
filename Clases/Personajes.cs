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
        List<Personajes> personajes = new List<Personajes>();
        
        public int RecibirDanio()
        {
            int danioRecibido = this.Vida - this.Defensa;
            Console.WriteLine($"{this.Nombre} recibe {danioRecibido} puntos de daño.");
            return danioRecibido;
        } 
        public int Atacar(Personajes enemigo)
        {
            int danio = this.Ataque - enemigo.Defensa;
            Console.WriteLine($"{this.Nombre} ataca a {enemigo.Nombre} y causa {danio} puntos de daño.");
            return danio;
        }
    }
}

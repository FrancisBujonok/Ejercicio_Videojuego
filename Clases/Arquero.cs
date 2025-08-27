using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arquero : Personajes
    {
        public Arquero(string nombre, int nivel) : base(nombre, nivel, 120, 25, 10)
        {
        }
        private Random Random = new Random();
        public int Atacar(Personajes enemigo)
        {
            int danio = this.Ataque - enemigo.Defensa;
            Console.WriteLine($"{this.Nombre} ataca a {enemigo.Nombre} y causa {danio} puntos de daño.");
            if (danio < 0)
            {
                danio = 0;
            }
            int numeroAleatorio = Random.Next(1, 5);
            if (numeroAleatorio == 4)
            {
                danio *= 2;
                Console.WriteLine($"¡{this.Nombre} ataca a {enemigo.Nombre} y causa un golpe crítico de {danio} puntos de daño!");
            }
            else
            {
                Console.WriteLine($"{this.Nombre} ataca a {enemigo.Nombre} y causa {danio} puntos de daño.");
            }
            return danio;
        }
    }
}
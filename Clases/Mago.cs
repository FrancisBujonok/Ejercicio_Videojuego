using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mago : Personajes
    {
        public Mago(string nombre, int nivel) :base(nombre, nivel, 100, 50, 5)
        { 
        }
        public int Atacar(Personajes enemigo)
        {
            int danio = this.Ataque - enemigo.Defensa;
            Console.WriteLine($"{this.Nombre} ataca a {enemigo.Nombre} y causa {danio} puntos de daño.");
            return danio;
        }
    }
}

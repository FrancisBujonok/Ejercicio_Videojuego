using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG;

namespace Clases
{
    public class Mago : Personajes
    {
        public Mago(string nombre, int nivel) 
        { 
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Vida = 100;
            this.Ataque = 50;
            this.Defensa = 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG;

namespace RPG
{
    public class Arquero : Personajes
    {
        public Arquero(string nombre, int nivel)
        {
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Vida = 120;
            this.Ataque = 25;
            this.Defensa = 10;
        }
    }
}

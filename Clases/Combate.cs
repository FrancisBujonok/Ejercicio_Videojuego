using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Combate
    {
        public Personajes Personaje1 { get; set; }
        public Personajes Personaje2 { get; set; }
        public string Vencedor { get; set; }
        public int CantDanioPersonaje1 { get; set; }
        public int CantDanioPersonaje2 { get; set; }
        public int DuracionCombate { get; set; }

        public Combate(Personajes personaje1, Personajes personaje2)
        {
            this.Personaje1 = personaje1;
            this.Personaje2 = personaje2;
            this.Vencedor = null;
            this.CantDanioPersonaje1 = 0;
            this.CantDanioPersonaje2 = 0;
            this.DuracionCombate = 0;
        }

    }
}

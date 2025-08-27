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
        public void IniciarCombate()
        {
            Console.Clear();
            Console.WriteLine($"Combate iniciado entre {Personaje1.Nombre} y {Personaje2.Nombre}!\n");
            Random rand = new Random();
            int turno = rand.Next(0, 2); // 0 para Personaje1, 1 para Personaje2
            while (Personaje1.Vida > 0 && Personaje2.Vida > 0)
            {
                if (turno == 0)
                {
                    int danio = Personaje1.Atacar(Personaje2);
                    Personaje2.Vida -= danio;
                    CantDanioPersonaje1 += danio;
                    Console.WriteLine($"{Personaje2.Nombre} tiene {Personaje2.Vida} puntos de vida restantes.\n");
                    turno = 1; // Cambiar turno
                }
                else
                {
                    int danio = Personaje2.Atacar(Personaje1);
                    Personaje1.Vida -= danio;
                    CantDanioPersonaje2 += danio;
                    Console.WriteLine($"{Personaje1.Nombre} tiene {Personaje1.Vida} puntos de vida restantes.\n");
                    turno = 0; // Cambiar turno
                }
                DuracionCombate++;
                System.Threading.Thread.Sleep(1000); // Pausa de 1 segundo para simular el tiempo del combate
            }
            if (Personaje1.Vida <= 0)
            {
                Vencedor = Personaje2.Nombre;
                Console.WriteLine($"{Personaje2.Nombre} ha ganado el combate!");
            }
            else
            {
                Vencedor = Personaje1.Nombre;
                Console.WriteLine($"{Personaje1.Nombre} ha ganado el combate!");
            }
            Console.WriteLine($"\nDuración del combate: {DuracionCombate} turnos");
            Console.WriteLine($"{Personaje1.Nombre} causó un total de {CantDanioPersonaje1} puntos de daño.");
            Console.WriteLine($"{Personaje2.Nombre} causó un total de {CantDanioPersonaje2} puntos de daño.");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

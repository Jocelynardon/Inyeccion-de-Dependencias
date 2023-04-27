using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias
{
    internal class BatallaFinal : InBatalla
    {
        private readonly InPersonaje villano;
        private readonly InPersonaje heroe;

        public BatallaFinal(InPersonaje villano, InPersonaje heroe)
        {
            this.villano = villano;
            this.heroe = heroe;
        }

        public string Ataque(bool character)
        {
            if (character)
            {
                return villano.InteraccionBatalla();
            }
            else
            {
                return heroe.InteraccionBatalla();
            }
        }

        public string PresentacionPersonaje(bool character)
        {
            if (character)
            {
                return villano.Nombre;
            }
            else
            {
                return heroe.Nombre;
            }
        }
    }
}

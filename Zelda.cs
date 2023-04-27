using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias
{
    internal class Zelda : InPersonaje
    {
        public string Nombre => "Zelda";
        public readonly InArma arma1;
        public readonly InArma arma2;

        public Zelda(InArma arma1, InArma arma2)
        {
            this.arma1 = arma1;
            this.arma2 = arma2;
        }

        public string InteraccionBatalla()
        {
            string frase = "";
            Random random = new Random();
            int weapon = random.Next(0, 2);
            if (weapon == 2)
            {
                frase = "Nunca lo lograrás " + arma1.Accion();
            }
            if (weapon == 1)
            {
                frase = "No podrás contra la voluntad de todo el reino " + arma2.Accion();
            }
            else
            {
                frase = "La luz siempre vence a la oscuridad";
            }
            return frase;
        }
    }
}

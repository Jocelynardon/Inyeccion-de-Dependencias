using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias
{
    internal class Ganondorf : InPersonaje
    {
        public string Nombre => "Ganondorf";
        public readonly InArma arma;

        public Ganondorf(InArma arma)
        {
            this.arma = arma;
        }

        public string InteraccionBatalla()
        {
            string frase = "";
            Random random = new Random();
            int weapon = random.Next(0, 2);
            if (weapon == 2)
            {
                frase = "Sucumbirán ante mi poder " + arma.Accion();
            }
            if (weapon == 1)
            {
                frase = "Hyrule será mío " + arma.Accion();
            }
            else
            {
                frase = "Conquistaré el mundo y sabrán quién soy";
            }
            return frase;
        }
    }
}

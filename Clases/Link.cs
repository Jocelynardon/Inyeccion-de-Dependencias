using Laboratorio_Inyección_Dependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias.Clases
{
    internal class Link : InPersonaje
    {
        public string Nombre => "Link";
        public readonly InArma arma1;
        public readonly InArma arma2;

        public Link(InArma arma1, InArma arma2)
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
                frase = "... (Toma el aliento y se endereza) " + arma1.Accion();
            }
            if (weapon == 1)
            {
                frase = "... (Se prepara para continuar con la batalla) " + arma2.Accion();
            }
            else
            {
                frase = "... (Corre para atacar)";
            }
            return frase;
        }
    }
}

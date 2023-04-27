using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias
{
    internal class Trifuerza : InArma
    {
        public string Accion()
        {
            Random random = new Random();
            int fragmento = random.Next(0, 2);
            switch (fragmento)
            {
                case 0:
                    return "(Toma el fragmento de Poder)";
                case 1:
                    return "(Toma el fragmento de Sabiduría)";
                case 2:
                    return "(Toma el fragmento de Coraje)";
                default:
                    return "";
            }
        }
    }
}

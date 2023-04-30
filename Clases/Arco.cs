using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio_Inyección_Dependencias.Interfaces;

namespace Laboratorio_Inyección_Dependencias.Clases
{
    internal class Arco : InArma
    {
        public string Accion()
        {
            return "(Prepara su arco)";
        }
    }
}

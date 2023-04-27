using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias
{
    internal interface InPersonaje
    {
        string Nombre { get; }
        string InteraccionBatalla();
    }
}

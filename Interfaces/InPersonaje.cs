using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias.Interfaces
{
    internal interface InPersonaje: ITransient
    {
        string Nombre { get; }
        string InteraccionBatalla();
    }
}

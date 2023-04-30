﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias.Interfaces
{
    internal interface InBatalla: ISingleton
    {
        string Ataque(bool character);
        string PresentacionPersonaje(bool character);
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Inyección_Dependencias
{
    internal interface ITransient:IControl
    {
        ServiceLifetime IControl.serviceLifeTime => ServiceLifetime.Transient;
    }
}

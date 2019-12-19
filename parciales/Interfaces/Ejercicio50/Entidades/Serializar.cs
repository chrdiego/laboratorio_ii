using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializar<S, V> : IGuardar<T, V>
    {
        V Leer()
        {
            return "Objeto leído";
        }
    }
}

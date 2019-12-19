using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TracikngIdRepetidoException : Exception
    {
        public TracikngIdRepetidoException(string mensaje) : base(mensaje) { }
        public TracikngIdRepetidoException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
    }
}

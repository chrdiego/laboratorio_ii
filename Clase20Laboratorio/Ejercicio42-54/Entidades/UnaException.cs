using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class UnaException : Exception
  {
    public UnaException(string mensaje, Exception inner) : base(mensaje ,inner)
    { }
    public UnaException(string mensaje) : base (mensaje)
    { }
  }
}

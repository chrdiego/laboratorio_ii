using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Ferreteria : Producto
  {
    protected float peso;

    public float Peso
    {
      get
      {
        return this.peso;
      }
    }
  }
}

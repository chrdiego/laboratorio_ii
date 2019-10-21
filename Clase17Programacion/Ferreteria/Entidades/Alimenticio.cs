using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Alimenticio : Producto
  {
    protected DateTime vencimiento;

    public DateTime Vencimiento
    {
      get
      {
        return this.vencimiento;
      }
    }
  }
}

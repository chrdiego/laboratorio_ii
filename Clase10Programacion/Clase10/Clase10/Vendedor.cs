using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  class Vendedor : Empleado
  {
    private int Objetivo { get; set; }

    public Vendedor(string nombre, int cuil, float sueldo, int objetivo)
    {
      this.Objetivo = objetivo;
    }

  }
}

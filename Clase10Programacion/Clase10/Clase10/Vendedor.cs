using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  class Vendedor : Empleado
  {
    public int Objetivo { get; set; }

    public Vendedor(string nombre, int cuil, float sueldo, int objetivo) : base (nombre, cuil, sueldo)
    {
      this.Objetivo = objetivo;
    }

    public override string Mostrar()
    {
      return base.Mostrar() + " obj: " this.Objetivo;
    }


  }
}

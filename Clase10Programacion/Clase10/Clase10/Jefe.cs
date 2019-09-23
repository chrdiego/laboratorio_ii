using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  class Jefe : Empleado
  {
    public int Bono { get; set; }

   public Jefe(string nombre, int cuil, float sueldo, int bono)
    {
      this.Bono = bono;
    }


  }

}

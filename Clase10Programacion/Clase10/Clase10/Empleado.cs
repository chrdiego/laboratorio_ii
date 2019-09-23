using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  public class Empleado : Persona
  {
   private float Sueldo { get; set; }

    public Empleado()
    {
      Empleado p = new Empleado();
    }

    public Empleado(string nombre, int cuil, float sueldo)
    {
      this.Sueldo = sueldo;
    }
  }
}

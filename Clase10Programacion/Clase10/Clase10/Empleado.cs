using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  public class Empleado : Persona
  {
   public float Sueldo { get; set; }
    public Empleado(string nombre, int cuil, float sueldo) : base(nombre, cuil)
    {
      this.Sueldo = sueldo;
    }

    public override string Mostrar()
    {
      return base.Mostrar() + " sue: " + this.Sueldo.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    public virtual void Aumentar(int porcentaje)
    {
      this.Sueldo = this.Sueldo + this.Sueldo * porcentaje / 100;
    }

  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  class Empresa
  {
    private Empleado nomina;
    private string razonSocial;
    private string direccion;
    private float ganancias;

    private Empresa(Empleado nomina)
    {
      this.nomina = nomina;
    }

    public Empresa(Empleado nomina, string razonSocial, string direccion, float ganancias) : this(nomina)
    {
      this.razonSocial = razonSocial;
      this.direccion = direccion;
      this.ganancias = ganancias;
    }


  }
}

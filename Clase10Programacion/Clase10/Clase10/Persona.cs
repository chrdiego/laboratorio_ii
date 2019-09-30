using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public abstract class Persona
    {
    public int Cuil { get; set; }
    public string Nombre { get; set; }
    public Persona(string nombre, int cuil)
    {
      this.Nombre = nombre;
      this.Cuil = cuil;
    }

    public virtual string Mostrar()
    {
      return "nom: " + this.Nombre + " cuil: " + this.Cuil;
    }
    }

}

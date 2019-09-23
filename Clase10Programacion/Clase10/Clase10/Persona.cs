using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Persona
    {
    private string nombre;
    private int cuil;

    public Persona()
    {
      Persona p = new Persona();
    }

    public Persona(string nombre, int cuil) : this()
    {
      this.nombre = nombre;
      this.cuil = cuil;
    }

    public string Nombre
    {
      get
      {
        return this.nombre;
      }
      set
      {
        this.nombre = value;
      }
    }

    public int Cuil
    {
      set
      {
        this.cuil = value;
      }
    }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
    public delegate void DelegadoString(string msg);
    private string apellido;
    private string nombre;
    public DelegadoString EventoString;

    public string Apellido { get; set; }
    public string Nombre { get; set; }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("NOMBRE: " + nombre + "\nAPELLIDO: " + apellido);
      return sb.ToString();
    }

    public Persona()
    {
      this.apellido = string.Empty;
      this.nombre = string.Empty;
    }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
  public class Mensaje : IMensaje
  {
    public string Usuario { get; set; }
    public string Texto { get; set; }
    public DateTime Hora { get; set; }

    public Mensaje(string usuario, string mensaje)
    {
      this.Usuario = usuario;
      this.Texto = mensaje;
      this.Hora = DateTime.Now;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(this.Hora + " - " + this.Usuario + ": " + this.Texto);
      return sb.ToString();
    }

    //void Serializar()
    //{
    //  string path = @"C:\Users\alumno\Desktop\2810";
    //  XmlWriter
    //}
  }
}

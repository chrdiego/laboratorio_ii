using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
  public class Alumno
  {
    byte nota1;
    byte nota2;
    float notaFinal;
    public string apellido;
    public int legajo;
    public string nombre;
    public void CalcularFinal()
    {
      Random r = new Random();
      if (this.nota1 >= 4 && this.nota2 >= 4)
        this.notaFinal = r.Next(0, 10);
      else
        this.notaFinal = -1;
    }
    public void Estudiar(byte notaUno, byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
    }
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("El alumno {1} {0} legajo {2} sacò {3} en el 1er examen y {4} en el 2do", this.apellido, this.nombre, this.legajo, this.nota1, this.nota2);
      if (this.notaFinal != -1)
        sb.AppendFormat(" y su nota final fue de {0}", this.notaFinal);
      return sb.ToString();
    }
  }
}

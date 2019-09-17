using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empleado
    {
    private string nombre;
    private string apellido;
    private string legajo;
    private EPuestoJerarquico puesto;
    private int salario;

    public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.legajo = legajo;
      this.puesto = puesto;
      this.salario = salario;
    }

    public static bool operator ==(Empleado e1, Empleado e2)
    {
      return e1.legajo == e2.legajo;
    }

    public static bool operator !=(Empleado e1, Empleado e2)
    {
      return !(e1.legajo == e2.legajo);
    }

    public string Mostrar(Empleado e1)
    {
      StringBuilder sb = new StringBuilder();
      return sb.AppendFormat("NOMBRE: {0}\nAPELLIDO: {1}\nLEGAJO: {2}\nPUESTO: {3}\nSALARIO: {4}\n", e1.nombre, e1.apellido, e1.legajo, e1.puesto, e1.salario).ToString();
    }

    public enum EPuestoJerarquico
    {
      ADMINISTRACION = 1,
      GERENCIA = 2,
      SISTEMAS = 3,
      ACCIONISTA = 4,
    }


    }
}

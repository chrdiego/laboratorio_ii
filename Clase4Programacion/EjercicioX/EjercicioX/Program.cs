using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioX
{
  class Program
  {
    static void Main(string[] args)
    {
      string nombre;
      string apellido;
      string sueldoBruto1;
      double sueldoBruto;
      Console.WriteLine("Ingrese un nombre: ");
      nombre = Console.ReadLine();
      Console.WriteLine("Ingrese un apellido: ");
      apellido = Console.ReadLine();
      Console.WriteLine("Ingrese un sueldo bruto: ");
      sueldoBruto1 = Console.ReadLine();
      double.TryParse(sueldoBruto1, out sueldoBruto);
      Empleado e1 = new Empleado(nombre,apellido,sueldoBruto);
      e1 = e1.CalcularNeto(sueldoBruto);
      Console.WriteLine(e1.Mostrar());
      Console.ReadKey();
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2Programacion;

namespace Clase2Programacion
{
  class Program
  {
    static void Main(string[] args)
    {
      string ingreso;
      int ingresoEntero;
      double salida = 0;
      do
      {
        Console.WriteLine("Ingrese un numero: ");
        ingreso = Console.ReadLine();
      } while (!int.TryParse(ingreso, out ingresoEntero));
      Console.WriteLine(Cuadrado.PotenciarNumero(ingresoEntero,out salida).ToString());
      Console.WriteLine(salida.ToString());
      Console.ReadKey();
    }
  }
}

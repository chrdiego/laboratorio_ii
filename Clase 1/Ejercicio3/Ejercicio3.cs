using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
  class Ejercicio3
  {
    static void Main(string[] args)
    {
      int numero;
      string ingreso;
      Console.WriteLine("Ingrese un numero:");
      ingreso = Console.ReadLine();
      while (!int.TryParse(ingreso,out numero))
      {
        Console.WriteLine("Ingrese un numero correctamente:");
        ingreso = Console.ReadLine();
      }

    }
  }
}

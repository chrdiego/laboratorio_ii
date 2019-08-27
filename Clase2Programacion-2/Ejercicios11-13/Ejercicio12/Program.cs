using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
  class Program
  {
    static void Main(string[] args)
    {
      int auxiliar;
      string numero;
      char ingreso;
      do
      {
        do
        {
          Console.WriteLine("Ingrese un numero: ");
          numero = Console.ReadLine();
        } while (int.TryParse(numero, out auxiliar));
        Console.WriteLine("¿Desea continuar? (S/N)");
        ingreso = Console.ReadKey().KeyChar;
      }while (ValidarRespuesta.ValidaS_N(ingreso));
    }
  }
}

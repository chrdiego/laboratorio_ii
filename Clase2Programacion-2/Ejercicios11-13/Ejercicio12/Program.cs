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
           Console.WriteLine("\nIngrese un numero: ");
           numero = Console.ReadLine();
                    if (!int.TryParse(numero, out auxiliar))
                        Console.WriteLine("\nERROR, solo se permiten numeros.");
        }while (!int.TryParse(numero, out auxiliar));
        Console.WriteLine("\n¿Desea continuar? (S/N)\n");
        ingreso = Console.ReadKey().KeyChar;
      }while (ValidarRespuesta.ValidaS_N(ingreso));
    }
  }
}
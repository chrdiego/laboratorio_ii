using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios14_16
{
  class CalculoDeArea
  {
    public static double CalcularCuadrado (double numero)
    {
      double resultado = 0;
      resultado = numero * numero;
      return resultado;
    }
    public static double CalcularTriangulo (double numero1, double numero2)
    {
      double resultado;
      resultado = numero1 * numero2;
      return resultado;
    }
    public static double CalcularCirculo (double numero)
    {
      double resultado;
      resultado = numero * 3.14;
      return resultado;
    }
  }
}

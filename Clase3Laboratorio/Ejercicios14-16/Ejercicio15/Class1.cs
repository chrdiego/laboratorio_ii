using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Calculadora
  {
    public static double Calcular(double numero1, double numero2, char operante)
    {
      double resultado = 0;
      switch(operante)
      {
        case '+':
          resultado = numero1 + numero2;
          break;
        case '-':
          resultado = numero1 - numero2;
          break;
        case '*':
          resultado = numero1 * numero2;
          break;
        case '/':
          if (Calculadora.Validar(numero2))
            resultado = numero1 / numero2;
          break;
        default:
          Console.WriteLine("\nError, operante desconocido.");
          break;
      }
      return resultado;
    }
    private static bool Validar(double numero2)
    {
      if (numero2 != 0)
        return true;
      else
        return false;
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2Programacion;

namespace Clase2Programacion
{
  public class Cuadrado
  {
    private int numeroInterno;
    public static bool PotenciarNumero(int numero, out double potencia)
    {
      potencia = 0;
      if (numero > 0)
      {
        potencia = Math.Pow(numero, 2);
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

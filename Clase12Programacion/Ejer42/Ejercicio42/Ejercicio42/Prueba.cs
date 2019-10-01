using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
  public class Prueba
  {
    public static void Test()
    {
      try
      {
        int j = 0;
        int i = 10 / j;

      }
      catch (DivideByZeroException ex)
      {
        throw ex;
      }
    }

    public Prueba()
    {
      try
      {
        Prueba.Test();
      }
      catch(DivideByZeroException ex)
      {
        throw ex;
      }
    }
  }
}

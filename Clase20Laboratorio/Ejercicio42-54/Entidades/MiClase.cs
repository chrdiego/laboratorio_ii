using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
    /// a.	Lanzar una excepción DivideByZeroException en un método estático
    public static void MetodoEstatico()
    {
      try
      {
        int aux = 0;
        int res = 10 / aux;
      }
      catch(DivideByZeroException e)
      {
        throw e;
      }
    }

    /// b.	Capturar la excepción del punto a en un constructor de instancia y...
    /// relanzarla hacia otro constructor de instancia.
    public MiClase()
    {
      try
      {
        MiClase.MetodoEstatico();
      }
      catch (DivideByZeroException e)
      {
        throw e;
      }
    }

    /// c.	En este segundo constructor, crear una excepción propia llamada UnaException
    /// (utilizar innerException para almacenar la excepción original) y volver a lanzarla.
    public MiClase(int a)
    {
      try
      {
        new MiClase();
      }
      catch(DivideByZeroException e)
      {
        throw new UnaException("2do constructor de instancia exception", e);
      }
    }
    }
}

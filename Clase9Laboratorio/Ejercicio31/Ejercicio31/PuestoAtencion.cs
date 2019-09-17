using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
  class PuestoAtencion
  {
    public enum Puesto
    {
      Caja1,
      Caja2
    }

    static int numeroActual;
    private Puesto puesto;

    static PuestoAtencion()
    {
      PuestoAtencion.numeroActual = 0;
    }

    #region PROPIEDADES
    public static int NumeroActual
    {
      get
      {
        return ++PuestoAtencion.numeroActual;
      }
    }
    #endregion
    #region MÉTODOS
    public bool Atender(Cliente cli)
    {
      System.Threading.Thread.Sleep(2000);
      return true;
    }

    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }
    #endregion
  }

}

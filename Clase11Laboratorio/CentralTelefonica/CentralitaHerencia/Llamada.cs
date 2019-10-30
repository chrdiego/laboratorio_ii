using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public abstract class Llamada
  {
    public enum TipoLlamada
    {
      Local, Provincial, Todas
    }

    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;
    
    #region PROPIEDADES
    public float Duracion
    {
      get
      {
        return this.duracion;
      }
    }

    public string NroDestino
    {
      get
      {
        return this.nroDestino;
      }
    }

    public string NroOrigen
    {
      get
      {
        return this.nroOrigen;
      }
    }
    #endregion
    #region MÉTODOS
    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    protected virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      return sb.AppendFormat("DURACION DE LA LLAMADA: {0}\nNUMERO DESTINO: {1}\nNUMERO ORIGEN: {2}\n", this.duracion, this.nroDestino, this.nroOrigen).ToString();
    }

    public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      return llamada1.Duracion.CompareTo(llamada2.Duracion);
    }

    public abstract float CostoLlamada
    {
      get;
    }

    public static bool operator ==(Llamada l1, Llamada l2)
    {
      if (!(l1 is null) && !(l2 is null))
      {
        if (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
          return true;
        else
          return false;
      }
      else
        return false;
    }

    public static bool operator !=(Llamada l1, Llamada l2)
    {
      return !(l1 == l2);
    }
    #endregion

  }
}

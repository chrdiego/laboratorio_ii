using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Centralita
  {

    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    #region PROPIEDADES

    public List<Llamada> Llamadas
    {
      get
      {
        return this.listaDeLlamadas;
      }
    }

    public float GananciaPorLocal
    {
      get
      {
        return this.CalcularGanancia(Llamada.TipoLlamada.Local);
      }
    }

    public float GananciaPorTotal
    {
      get
      {
        return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
      }
    }

    public float GananciaPorProvincial
    {
      get
      {
        return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
      }
    }

    #endregion
    #region METODOS

    public Centralita()
    {
      this.listaDeLlamadas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa) : this()
    {
      this.razonSocial = nombreEmpresa;
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float ganancia = 0;
      switch (tipo)
      {
        case (Llamada.TipoLlamada)0:
          foreach (Llamada llamada in Llamadas)
          {
            if (llamada is Local)
            {
              Local local = (Local)llamada;
              ganancia += local.CostoLlamada;
            }
          }
          break;
        case (Llamada.TipoLlamada)1:
          foreach (Llamada llamada in Llamadas)
          {
            if (llamada is Provincial)
            {
              Provincial provincial = (Provincial)llamada;
              ganancia += provincial.CostoLlamada;
            }
          }
          break;
        case (Llamada.TipoLlamada)2:
          {
            foreach (Llamada llamada in Llamadas)
            {
              if (llamada is Local)
              {
                Local local = (Local)llamada;
                ganancia += local.CostoLlamada;
              }
              else if (llamada is Provincial)
              {
                Provincial provincial = (Provincial)llamada;
                ganancia += provincial.CostoLlamada;
              }
            }
          }
          break;
      }
      return ganancia;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("*********************************************\nRazon social: " + this.razonSocial + "\nGanancia total: " + GananciaPorTotal.ToString() + "\nGanancia local: " + GananciaPorLocal.ToString() + "\nGanancia provincial: " + GananciaPorProvincial.ToString() + "\n-------------------------------------\n").ToString();
      foreach (Llamada llamada in this.Llamadas)
      {
        sb.AppendLine("Detalles: ");
        sb.Append(llamada.ToString());
        sb.AppendLine("------------------------\n");
      }
      sb.AppendLine("***********************************");
      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    public void OrdenarLlamadas()
    {
      this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
    }

    public static bool operator ==(Centralita c, Llamada llamada)
    {
      foreach(Llamada l in c.listaDeLlamadas)
      {
        if (l.Equals(llamada))
          return true;
      }
      return false;
    }

    public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
    {
      if (!(c == nuevaLlamada))
      {
        c.AgregarLlamada(nuevaLlamada);
        return c;
      }
      else return c;
    }

    public static bool operator !=(Centralita c, Llamada llamada)
    {
      return !(c == llamada);
    }

    private void AgregarLlamada(Llamada nuevaLlamada)
    {
      this.listaDeLlamadas.Add(nuevaLlamada);
    }
    #endregion
  }
}

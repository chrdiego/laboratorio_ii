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
    string razonSocial;

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

    public Centralita(string nombreEmpresa)
    {
      this.razonSocial = nombreEmpresa;
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float ganancia = 0;
      switch(tipo)
      {
        case (Llamada.TipoLlamada)0:
          ganancia = 5;
          break;
        case (Llamada.TipoLlamada)1:
          ganancia = 6;
          break;
        case (Llamada.TipoLlamada)2:
          ganancia = 7;
          break;
      }
      return ganancia;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      return sb.Append("Razon social: " + this.razonSocial + "\nGanancia total: ").ToString();
    }

    public void OrdenarLlamadas()
    {
      this.Llamadas.Sort();
    }
    #endregion
  }
}

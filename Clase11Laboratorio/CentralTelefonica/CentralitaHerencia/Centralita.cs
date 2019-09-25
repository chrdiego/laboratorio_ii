using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Centralita
  {
    List<Llamada> listaDeLlamadas;
    string razonSocial;

    #region PROPIEDADES

    public List<Llamada> Llamadas
    {
      get
      {
        return this.listaDeLlamadas;
      }
    }

    #endregion
    #region METODOS
    public Centralita()
    {
      listaDeLlamadas = new List<Llamada>();
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      switch(tipo)
      {
        case 0:
          return
      }
    }

    private string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      return sb.AppendFormat("").ToString();
    }

    public void OrdenarLlamadas()
    {

    }

 

    #endregion
  }
}

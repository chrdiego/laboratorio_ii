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

    #endregion
    #region METODOS
    public Centralita()
    {
      listaDeLlamadas = new List<Llamada>();
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {

    }

    public string Mostrar()
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
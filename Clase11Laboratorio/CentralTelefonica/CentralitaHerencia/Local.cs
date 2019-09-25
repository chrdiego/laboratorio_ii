using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Local : Llamada
  {
    private float costo;

    public float CostoLlamada
    {
      get
      {
        return this.CalcularCosto();
      }
    }

    public Local(string origen, float duracion, string destino, float costo) : base (duracion, destino, origen)
    {
      this.nroOrigen = NroOrigen;
      this.duracion = Duracion;
      this.nroDestino = NroDestino;
      this.costo = CostoLlamada;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      base.Mostrar();
      return sb.AppendFormat(" COSTO DE LLAMADA: {0}", this.CostoLlamada).ToString();
    }

    private float CalcularCosto()
    {
      return this.costo * this.duracion;
    }
  }
}

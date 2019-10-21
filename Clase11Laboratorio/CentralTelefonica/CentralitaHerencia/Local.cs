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
      this.costo = costo;
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("COSTO DE LLAMADA: {0}\n", this.CostoLlamada).ToString();
      sb.AppendLine(base.Mostrar());
      return sb.ToString();
    }

    private float CalcularCosto()
    {
      return this.costo * this.duracion;
    }
  }
}

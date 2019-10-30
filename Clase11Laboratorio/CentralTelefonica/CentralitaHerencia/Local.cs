using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Local : Llamada
  {
    protected float costo;

    public override float CostoLlamada
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

    protected override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("COSTO DE LLAMADA: {0}\n", this.CostoLlamada).ToString();
      sb.AppendLine(base.Mostrar());
      return sb.ToString();
    }

    public override bool Equals(object obj)
    {
      if (obj is Local)
        return true;
      else return false;
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    private float CalcularCosto()
    {
      return this.costo * this.duracion;
    }
  }
}

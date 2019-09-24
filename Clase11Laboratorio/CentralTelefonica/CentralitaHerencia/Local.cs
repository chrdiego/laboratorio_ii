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
        return this.costo;
      }
    }

    public Local(Llamada llamada, float costo)
    {
      
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

    }
  }
}

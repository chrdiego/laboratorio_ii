using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class Provincial : Llamada
  {
    public enum Franja
    {
      Franja_1 = 0, Franja_2 = 1, Franja_3 = 2
    }

    private Franja franjaHoraria;

    public float CostoLlamada
    {
      get
      {
        return this.CalcularCosto();
      }
    }

    private float CalcularCosto()
    {
      float costo = 0;
      switch(this.franjaHoraria)
      {
        case (Franja)0:
          costo = this.Duracion * 0.99f;
          break;
        case (Franja)1:
          costo = this.Duracion * 1.25f;
          break;
        case (Franja)2:
          costo = this.Duracion * 0.66f;
          break;
      }
      return costo;
    }

    public override string Mostrar()
    {
      base.Mostrar();
      StringBuilder sb = new StringBuilder();
      return sb.AppendFormat("COSTO: {0}\nFRANJA HORARIA: {1}", this.CostoLlamada, this.franjaHoraria).ToString();
    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino) : base (duracion, destino, origen)
    {
      this.franjaHoraria = miFranja;
    }

    public Provincial(Franja miFranja, Llamada llamada) : base (llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    {
    }
  }
}

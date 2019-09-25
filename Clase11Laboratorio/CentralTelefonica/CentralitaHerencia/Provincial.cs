using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Provincial : Llamada
  {
    public enum Franja
    {
      Franja_1, Franja_2, Franja_3
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
        case 0:
          costo = this.Duracion * 0.99f;
          break;
        case 1:
          costo = this.Duracion * 1.25f;
          break;
        case 2:
          costo = this.Duracion * 0.66f;
          break;
      }
      return costo;
    }

    public bool Equals(object obj)
    {

    }

    private string Mostrar()
    {

    }

    public Provincial(Franga miFranja, Llamada llamada)
    {

    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino)
    {

    }

  }
}

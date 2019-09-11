using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios20_26
{
  public class Euro
  {
    private double cantidad;
    private static double cotizRespectoDolar;

    static Euro()
    {
      Euro.cotizRespectoDolar = 1 / 1.3642f;
    }

    public Euro(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
    {
      Euro.cotizRespectoDolar = cotizRespectoDolar;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public static double GetCotizacion()
    {
      return Euro.cotizRespectoDolar;
    }

    // Conversiones

    public static implicit operator Euro(double d)
    {
      Euro aux = new Euro(d);
      return aux;
    }

    public static explicit operator Dolar(Euro p)
    {
      return new Dolar(p.cantidad / Euro.GetCotizacion());
    }

    public static explicit operator Pesos(Euro p)
    {
      return new Pesos(p.cantidad / Euro.GetCotizacion());
    }

    // Operaciones

    public static Euro operator +(Euro e, Dolar d)
    {
      Euro aux = new Euro(e.cantidad + ((Euro)d).cantidad);
      return aux;
    }

    public static Euro operator -(Euro e, Dolar d)
    {
      Euro aux = new Euro(e.cantidad - ((Euro)d).cantidad);
      return aux;
    }

    public static Euro operator +(Euro e, Pesos p)
    {
      Euro aux = new Euro(e.cantidad + ((Euro)p).cantidad);
      return aux;
    }

    public static Euro operator -(Euro e, Pesos p)
    {
      Euro aux = new Euro(e.cantidad - ((Euro)p).cantidad);
      return aux;
    }

    // Comparaciones

    public static bool operator ==(Euro e1, Euro e2)
    {
      return e1.cantidad == e2.cantidad;
    }

    public static bool operator !=(Euro e1, Euro e2)
    {
      return !(e1 == e2);
    }

    public static bool operator ==(Euro e, Dolar d)
    {
      return e == (Euro)d;
    }

    public static bool operator !=(Euro e, Dolar d)
    {
      return !(e == d);
    }

    public static bool operator ==(Euro e, Pesos p)
    {
      return e == (Euro)p;
    }

    public static bool operator !=(Euro e, Pesos p)
    {
      return !(e == p);
    }
  }
}

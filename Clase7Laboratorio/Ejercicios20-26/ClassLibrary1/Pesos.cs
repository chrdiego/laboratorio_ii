using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios20_26
{
  public class Pesos
  {
    private double cantidad;
    private static double cotizRespectoDolar;

    private Pesos()
    {
      Pesos.cotizRespectoDolar = 38.33f;
    }

    public Pesos(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Pesos(double cantidad, double cotizRespectoDolar):this(cantidad)
    {
      Pesos.cotizRespectoDolar = cotizRespectoDolar;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public static double GetCotizacion()
    {
      return Pesos.cotizRespectoDolar;
    }

    // Conversiones

    public static implicit operator Pesos(double p)
    {
      Pesos aux = new Pesos(p);
      return aux;
    }

    public static explicit operator Dolar(Pesos p)
    {
      return new Dolar(p.cantidad / Pesos.GetCotizacion());
    }

    public static explicit operator Euro(Pesos p)
    {
      return new Euro(p.cantidad / Pesos.GetCotizacion());
    }

    // Operaciones

    public static Pesos operator +(Pesos p, Euro e)
    {
      Pesos aux = new Pesos(p.cantidad + ((Pesos)e).cantidad);
      return aux;
    }

    public static Pesos operator +(Pesos p, Dolar d)
    {
      Pesos aux = new Pesos(p.cantidad + ((Pesos)d).cantidad);
      return aux;
    }

    public static Pesos operator -(Pesos p, Euro e)
    {
      Pesos aux = new Pesos(p.cantidad + ((Pesos)e).cantidad);
      return aux;
    }

    public static Pesos operator -(Pesos p, Dolar d)
    {
      Pesos aux = new Pesos(p.cantidad + ((Pesos)d).cantidad);
      return aux;
    }

    // Comparaciones

    public static bool operator ==(Pesos p1, Pesos p2)
    {
      return p1.cantidad == p2.cantidad;
    }

    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return !(p1 == p2);
    }

    public static bool operator ==(Pesos p, Dolar d)
    {
      return (p == (Pesos)d);
    }

    public static bool operator !=(Pesos p, Dolar d)
    {
      return !(p == d);
    }

    public static bool operator ==(Pesos p, Euro e)
    {
      return p == (Pesos)e;
    }

    public static bool operator != (Pesos p, Euro e)
    {
      return !(p == e);
    }
  }
}

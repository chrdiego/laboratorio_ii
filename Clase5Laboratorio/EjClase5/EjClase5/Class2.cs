using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjClase5
{
  public class Estante
  {
    int ubicacionEstante;
    Producto[] productos;

    private Estante(int capacidad)
    {
      this.productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this (capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos()
    {
      return productos;
    }

    public static string MostrarEstante(Estante e)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("PRODUCTOS: {0}\nUBICACION: {1}", e.productos, e.ubicacionEstante);
      return sb.ToString();
    }

    public static bool operator ==(Estante e, Producto p)
    {
      //return (e == p);
      return (e.productos.Equals(p));
    }

    public static bool operator !=(Estante e, Producto p)
    {
      //return !(e == p);
      return !(e.productos.Equals(p));
    }

    public static bool operator +(Estante e, Producto p)
    {
      
    }

    public static Estante operator -(Estante e, Producto p)
    {

    }

  }
}

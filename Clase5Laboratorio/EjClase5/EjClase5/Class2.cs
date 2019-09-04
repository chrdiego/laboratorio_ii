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
      int i;
      for(i=0;e==null;i++)
      {
        if (e.productos[i] == p)
          return true;
        else
          return false;
      }
    }

    public static bool operator !=(Estante e, Producto p)
    {
      int i;
      for (i = 0; e.productos == null; i++)
      {
        if !(e.productos[i] == p)
          return true;
        else
          return false;
      }
    }

    public static bool operator +(Estante e, Producto p)
    {
      int i;
      do
      {

      }
    }

    public static Estante operator -(Estante e, Producto p)
    {

    }

  }
}

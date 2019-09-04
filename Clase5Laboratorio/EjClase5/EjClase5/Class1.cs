using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjClase5
{
  public class Producto
  {
    string codigoDeBarra;
    string marca;
    float precio;

    public Producto(string marca, string codigo, float precio)
    {
      this.marca = marca;
      this.codigoDeBarra = codigo;
      this.precio = precio;
    }

    public string GetMarca()
    {
      return this.marca;
    }

    public float GetPrecio()
    {
      return this.precio;
    }

    static string MostrarProducto(Producto p)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("MARCA: {0}\nCODIGO DE BARRA: {1}\nPRECIO: {2}", p.marca, p.codigoDeBarra, p.precio);
      return sb.ToString();
    }


    public static bool operator ==(Producto p1, Producto p2)
    {
      return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
      //if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
      //  return true;
      //else
      //  return false;
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
      return !(p1 == p2);
      //Siempre tiene que estar negado
    }

    public static bool operator ==(Producto p,string marca)
    {
      return (p.marca == marca);
      //if (p.marca == marca)
      //  return true;
      //else
      //  return false;
    }

    public static bool operator !=(Producto p,string marca)
    {
      return !(p.marca == marca);
      //Siempre tiene que estar negado
    }

    public static explicit operator string(Producto p)
    {
      p.marca.ToString();
      p.codigoDeBarra.ToString();
      p.precio.ToString();
      return p.codigoDeBarra;
    }
  }
}

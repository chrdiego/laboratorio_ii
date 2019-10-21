using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Estanteria<T> where T : Producto
  {
    private int tamaño;
    private T[] productos;

    public Estanteria(int tamaño)
    {
      this.tamaño = tamaño;
      this.productos = new T[tamaño];
    }


    public static bool operator +(Estanteria<T> estanteria, Producto producto)
    {
      bool flag = false;
      float contador = 0;
      if(estanteria != null && producto != null)
      {
        foreach(Producto a in estanteria.productos)
        {
          if(a.Id_prod == producto.Id_prod)
          {
            flag = true;
          }
          contador++;
          if (flag == false && contador < estanteria.tamaño)
          {
            estanteria.productos.Add(producto);
            return true;
          }
        }
      }
      return false;
    }

    public static bool operator -(Estanteria<T> estanteria, Producto producto)
    {
      int i = 0;
      bool flag = false;
      foreach(Producto a in estanteria.productos)
      {
        if(a.Id_prod == producto.Id_prod)
        {
          flag = true;
          break;
        }
        i++;
      }
      if (flag == true)
      {
        estanteria.productos.RemoveAt(i);
        return true;
      }
      return false;
    }

  }
}

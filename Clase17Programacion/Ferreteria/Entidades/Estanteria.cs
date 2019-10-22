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
    //private List<T> productos;

    public Estanteria(int tamaño)
    {
      this.tamaño = tamaño;
      this.productos = new T[tamaño];
      //this.productos = new List<T>();
    }

    public int Tamaño
    {
      get
      {
        return this.tamaño;
      }
    }


    public static bool operator +(Estanteria<T> estanteria, Producto producto)
    {
      bool flag = false;
      int contador = 0;
      if(estanteria != null && producto != null)
      {
        for(int i = 0; i < estanteria.Tamaño; i++)
        {
          if(producto == estanteria.productos[i])
          {
          flag = true;
          contador++;
          break;
          }
        }
        if (flag == false && contador < estanteria.Tamaño)
        {
          estanteria.productos[contador] = (T)producto;
          return true;
        }
        /*
        foreach(Producto a in estanteria.productos)
        {
          if(a.Id_prod == producto.Id_prod)
            flag = true;
          contador++;
          if (flag == false && contador < estanteria.tamaño)
          {
            estanteria.productos[contador] = (T)producto;
            //estanteria.productos.Add((T)producto);
            return true;
          }
        }
      }*/
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
        estanteria.productos[i] = null;
        //estanteria.productos.RemoveAt(i);
        return true;
      }
      return false;
    }
  }
}

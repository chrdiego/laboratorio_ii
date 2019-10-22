using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
    private int id_prod;
    private string descripcion;

    public Producto(int id, string desc)
    {
      this.id_prod = id;
      this.descripcion = desc;
    }

    public int Id_prod
    {
      get
      {
        return this.id_prod;
      }
    }

    public string Descripcion
    {
      get
      {
        return this.descripcion;
      }
    }


    }
}

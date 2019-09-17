using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
  public class Negocio
  {
    PuestoAtencion caja;
    Queue<Cliente> clientes;
    string nombre;

    private Negocio()
    {
      this.clientes = new Queue<Cliente>();
    }

    public Cliente Cliente
    {
      get
      {
        return this.clientes.Dequeue();
      }
      set
      {
        bool rta = (this + value);
      }
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      if(n != c)
      {
        n.clientes.Enqueue(c);
        return true;
      }
      return false;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      foreach(Cliente e in n.clientes)
      {
        if (e == c)
          return true;
      }
      return false;
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
      return !(n == c);
    }

    public static bool operator ~(Negocio n)
    {
      return n.caja.Atender(n.Cliente);
    }

    public int ClientesPendientes(Cliente c, Negocio n)
    {
      int contador = 0;
      foreach(Cliente e in n.clientes)
      {
        contador++;
      }
      return contador;     
    }
  } 
}

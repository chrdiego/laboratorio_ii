using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        MiOtraClase aux = new MiOtraClase();
        aux.MiMetodoInstancia();
      }


      catch(MiException e)
      {
        //e.	MiException será capturada en el Main,
        // mostrando el mensaje de error que esta almacena por pantalla
        // y los mensajes de todas las excepciones almacenadas en sus innerException.
        Console.WriteLine(e.Message);
        if(!object.ReferenceEquals(e.InnerException, null))
        {
          Exception ex = e.InnerException;
          do
          {
            Console.WriteLine(ex.Message);
            ex = ex.InnerException;
          } while (!object.ReferenceEquals(ex, null));
        }
      }
      Console.ReadKey();
    }
  }
}

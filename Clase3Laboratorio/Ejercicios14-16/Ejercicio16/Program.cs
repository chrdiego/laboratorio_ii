using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno a1 = new Alumno();
      a1.nombre = "Juan";
      a1.apellido = "Perez";
      a1.legajo = 121212;
      a1.Estudiar(2, 10);
      a1.CalcularFinal();
      Console.WriteLine(a1.Mostrar());

      Alumno a2 = new Alumno();
      a2.nombre = "Carlos";
      a2.apellido = "Ramon";
      a2.legajo = 121313;
      a2.Estudiar(4, 10);
      a2.CalcularFinal();
      Console.WriteLine(a2.Mostrar());

      Alumno a3 = new Alumno();
      a3.nombre = "Roberto";
      a3.apellido = "Simon";
      a3.legajo = 303030;
      a3.Estudiar(8, 10);
      a3.CalcularFinal();
      Console.WriteLine(a3.Mostrar());
      Console.ReadKey();
    }
  }
}

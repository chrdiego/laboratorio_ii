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
      DateTime d1 = new DateTime(1);
      DateTime d2 = new DateTime(0);

      Torneo<EquipoFutbol> torneoFtubol = new Torneo<EquipoFutbol>("Copa1");
      Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Copa2");

      EquipoFutbol equipoFutbol1 = new EquipoFutbol("Boca", d1);
      EquipoFutbol equipoFutbol2 = new EquipoFutbol("River", d2);
      EquipoFutbol equipoFutbol3 = new EquipoFutbol("Racing", d1);
      EquipoBasquet equipoBasquet1 = new EquipoBasquet("Spurs", d1);
      EquipoBasquet equipoBasquet2 = new EquipoBasquet("Lakers", d2);
      EquipoBasquet equipoBasquet3 = new EquipoBasquet("Argentinos", d1);

      torneoFtubol += equipoFutbol1;
      torneoFtubol += equipoFutbol2;
      torneoFtubol += equipoFutbol3;
      torneoBasquet += equipoBasquet1;
      torneoBasquet += equipoBasquet2;
      torneoBasquet += equipoBasquet3;

      Console.WriteLine(torneoFtubol.Mostrar());
      Console.WriteLine(torneoBasquet.Mostrar());
      Console.ReadKey();
    }
  }
}

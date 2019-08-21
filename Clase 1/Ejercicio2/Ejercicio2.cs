using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
  class Ejercicio2
  {
    static void Main(string[] args)
    {
      float auxiliar;
      double cuadrado = 0;
      double cubo = 0;
      string ingreso;
      Console.WriteLine("Ingrese un numero:");
      ingreso = Console.ReadLine();
      while(!float.TryParse(ingreso,out auxiliar))
      {
        Console.WriteLine("Ingrese un numero:");
        ingreso = Console.ReadLine();
      }
        while (auxiliar< 0)
        {
        Console.WriteLine("Ingrese un numero MAYOR a 0");
        ingreso = Console.ReadLine();
        while (!float.TryParse(ingreso, out auxiliar))
          {
          Console.WriteLine("Ingrese un numero VALIDO");
            ingreso = Console.ReadLine();
          }
        }
        cubo = Math.Pow(auxiliar, 3);
        cuadrado = Math.Pow(auxiliar, 2);
      Console.Clear();
        Console.WriteLine("NUMERO: {0,10}", auxiliar);
        Console.WriteLine("CUBO: {0,10}", cubo);
        Console.WriteLine("CUADRADO: {0,10}", cuadrado);
      Console.ReadKey();
    }
  }
}

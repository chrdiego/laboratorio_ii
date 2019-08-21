using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
  class Ejercicio1
  {
    static void Main(string[] args)
    {
      int auxiliar;
      int min = 0;
      int max = 0;
      float promedio = 0;
      int i;
      string ingreso;

      for(i = 0; i < 5 ;i++)
      {
        Console.WriteLine("Ingrese un numero: ");
        ingreso = Console.ReadLine();
        if(int.TryParse(ingreso, out auxiliar))
        {
          if (i == 0)
          {
            max = auxiliar;
            min = auxiliar;
            promedio = auxiliar;
          }
          else
          {
            if (auxiliar > max)
              max = auxiliar;
            if (auxiliar < min)
              min = auxiliar;
            promedio = promedio + auxiliar;
          }
        }
        else
          i--;
      }
      promedio = promedio / 5;
      Console.Clear();
      Console.WriteLine("Promedio:{0}", promedio);
      Console.WriteLine("Max: {0}", max);
      Console.WriteLine("Min: {0}", min);
      Console.ReadKey();
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int numero;
            string ingreso;
            Console.WriteLine("Ingrese un numero:");
            ingreso = Console.ReadLine();
            while (!int.TryParse(ingreso, out numero))
            {
                Console.WriteLine("Ingrese un numero correctamente:");
                ingreso = Console.ReadLine();
            }
            int i = 0;
            Console.WriteLine("Numeros primos de {0}: ", ingreso);
            for(int j=2;j <= numero;j++)
            {
                for(i = 2; i < j; i++)
                {
                    if ((j % i) == 0)
                        break;
                }
                if (i == j)
                    Console.WriteLine("{0} es primo", j);
            }
            Console.ReadKey();
    }
  }
}

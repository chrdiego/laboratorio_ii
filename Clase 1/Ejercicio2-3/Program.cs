using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float auxiliar = 0;
            double cuadrado = 0;
            double cubo = 0;
            string ingreso;
            Console.WriteLine("Ingrese un numero: ");
            ingreso = Console.ReadLine();
            while(!float.TryParse(ingreso, out auxiliar))
            {
                Console.WriteLine("Ingrese un numero: ");
                ingreso = Console.ReadLine();
                while(float.TryParse(ingreso, out auxiliar))
                {
                    while(auxiliar < 0)
                    {
                        Console.WriteLine("Ingrese un numero mayor a 0: ");
                        ingreso = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("{0}", auxiliar);
            Console.ReadKey();
        }
    }
}

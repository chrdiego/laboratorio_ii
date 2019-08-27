using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            float auxiliar = 0;
            string ingreso;
            Console.WriteLine("Ingrese un numero:");
            ingreso = Console.ReadLine();
            while (!float.TryParse(ingreso, out auxiliar))
            {
                Console.WriteLine("Ingrese un numero:");
                ingreso = Console.ReadLine();
            }
            while (auxiliar < 0)
            {
                Console.WriteLine("Ingrese un numero MAYOR a 0");
                ingreso = Console.ReadLine();
                while (!float.TryParse(ingreso, out auxiliar))
                {
                    Console.WriteLine("Ingrese un numero VALIDO");
                    ingreso = Console.ReadLine();
                }
            }

            Console.WriteLine("{0}", auxiliar);
        }
    }
}

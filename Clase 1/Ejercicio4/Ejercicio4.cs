using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            short perfectosEncontrados = 0;
            int numero = 1;
            while(perfectosEncontrados < 4)
            {
                int sumador = 0;
                for (int i = numero-1; i > 0; i--)
                {
                    if((numero%i)==0)
                    {
                        sumador += i;
                        if (sumador > numero)
                            break;
                    }
                }
                if (sumador == numero)
                {
                    perfectosEncontrados++;
                    Console.WriteLine("El numero {0} es PERFECTO", numero);
                }
                numero++;
            }
            Console.ReadKey();
        }
    }
}

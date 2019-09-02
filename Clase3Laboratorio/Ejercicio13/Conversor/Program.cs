using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario = "";
            double numeroDecimal = 0;
            Console.WriteLine("Ingrese un numero decimal:");
            numeroDecimal = double.Parse(Console.ReadLine());
            Console.WriteLine(numeroDecimal + " = " + Conversor.DecimalBinario(numeroDecimal));
            Console.WriteLine("Ingrese un numero binario:");
            binario = Console.ReadLine();
            Console.WriteLine(binario + " = " + Conversor.BinarioDecimal(binario));

            Console.WriteLine("Ingrese un numero decimal Facil:");
            numeroDecimal = double.Parse(Console.ReadLine());
            Console.WriteLine(numeroDecimal + " = " + Conversor.DecimalBinarioFacil(numeroDecimal));
            Console.WriteLine("Ingrese un numero binario Facil:");
            binario = Console.ReadLine();
            Console.WriteLine(binario + " = " + Conversor.BinarioDecimalFacil(binario));
            Console.ReadKey();
        }
    }
}

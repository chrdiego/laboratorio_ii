using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salida
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            long digitos = 0;
            Console.Write("\nIngrese un numero: ");
            respuesta = Console.ReadLine();
            digitos = CantidadDeDigitos.CantidadDeDigitos.Metodo(respuesta);
            Console.WriteLine("Cantidad de digitos: " + digitos + " dígitos.");
            Console.ReadKey();
            Console.WriteLine("\n\n----------------------");
            Console.Write("Ingrese una cadena de caracteres: ");
            respuesta = Console.ReadLine();
            Console.WriteLine(ClassLibrary1.ExtendidoString.Metodo(respuesta));
            Console.ReadKey();
        }
    }
}

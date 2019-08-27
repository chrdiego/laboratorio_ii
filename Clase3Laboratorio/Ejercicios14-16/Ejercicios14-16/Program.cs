using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios14_16
{
  class Program
  {
    static void Main(string[] args)
    {
      double numero = 0;
      double numero2 = 0;
      string ingreso;
      double cuadrado = 0;
      double triangulo = 0;
      double circulo = 0;
      char respuesta;
      do
      {
        Console.WriteLine("A) Calcular cuadrado");
        Console.WriteLine("B) Calcular triangulo");
        Console.WriteLine("C) Calcular circulo");
        Console.WriteLine("D) Salir");
        Console.WriteLine("Ingrese respuesta: ");
        respuesta = Console.ReadKey().KeyChar;
        switch (respuesta)
        {
          case 'a':
            do
            {
              do
              {
                Console.WriteLine("\nIngrese un numero: ");
                ingreso = Console.ReadLine();
                if (!double.TryParse(ingreso, out numero))
                  Console.WriteLine("\nERROR, no ha ingresado un numero.\n");
              } while (!double.TryParse(ingreso, out numero));
              if (numero < 0)
                Console.WriteLine("\nERROR, el numero ingresado es menor a 0\n");
            } while (numero < 0);
            cuadrado = CalculoDeArea.CalcularCuadrado(numero);
            Console.WriteLine("Area del cuadrado es de: {0}", cuadrado);
            Console.ReadKey();
            break;
          case 'b':
            do
            {
              do
              {
                Console.WriteLine("\nIngrese una base: ");
                ingreso = Console.ReadLine();
                if (!double.TryParse(ingreso, out numero))
                  Console.WriteLine("\nERROR, no ha ingresado un numero.\n");
              } while (!double.TryParse(ingreso, out numero));
              if (numero < 0)
                Console.WriteLine("\nERROR, el numero ingresado es menor a 0\n");
            } while (numero < 0);
            do
            {
              do
              {
                Console.WriteLine("\nIngrese una altura: ");
                ingreso = Console.ReadLine();
                if (!double.TryParse(ingreso, out numero2))
                  Console.WriteLine("\nERROR, no ha ingresado un numero.\n");
              } while (!double.TryParse(ingreso, out numero2));
              if (numero2 < 0)
                Console.WriteLine("\nERROR, el numero ingresado es menor a 0\n");
            } while (numero2 < 0);
            triangulo = CalculoDeArea.CalcularTriangulo(numero, numero2);
            Console.WriteLine("Area del triangulo es de: {0}", triangulo);
            Console.ReadKey();
            break;
          case 'c':
            do
            {
              do
              {
                Console.WriteLine("Ingrese un radio: ");
                ingreso = Console.ReadLine();
                if (!double.TryParse(ingreso, out numero2))
                  Console.WriteLine("\nERROR, no ha ingresado un numero.\n");
              } while (!double.TryParse(ingreso, out numero2));
              if (numero2 < 0)
                Console.WriteLine("\nERROR, el numero ingresado es menor a 0\n");
            } while (numero2 < 0);
            circulo = CalculoDeArea.CalcularCirculo(numero2);
            Console.WriteLine("Area del circulo es de: {0}", circulo);
            Console.ReadKey();
            break;
          default:
            break;
        }
        Console.WriteLine("¿Desea continuar? (S/N)");
        respuesta = Console.ReadKey().KeyChar;
      } while (respuesta == 's');
    }
  }
}

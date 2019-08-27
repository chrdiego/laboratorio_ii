using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Program
  {
    static void Main(string[] args)
    {
      double numero1 = 0;
      double numero2 = 0;
      double resultado = 0;
      char operante;
      string ingreso;
      do
      {
        Console.Clear();
        Console.WriteLine("INGRESE UN OPERANTE");
        Console.WriteLine("+ para sumar");
        Console.WriteLine("- para restar");
        Console.WriteLine("* para multiplicar");
        Console.WriteLine("/ para dividir");
        operante = Console.ReadKey().KeyChar;
        while(operante != '+' && operante != '-' && operante != '*' && operante != '/')
        {
          Console.WriteLine("\nError, ingrese un operante correcto");
          operante = Console.ReadKey().KeyChar;
        }
        do
        {
          do
          {
            Console.WriteLine("\nIngrese el primer numero: ");
            ingreso = Console.ReadLine();
            if (!double.TryParse(ingreso, out numero1))
              Console.WriteLine("\nERROR, no ha ingresado un numero.\n");
          } while (!double.TryParse(ingreso, out numero1));
          if (numero1< 0)
            Console.WriteLine("\nERROR, el numero ingresado es menor a 0\n");
        } while (numero1 < 0);
        do
        {
          do
          {
            Console.WriteLine("\nIngrese el segundo numero: ");
            ingreso = Console.ReadLine();
            if (!double.TryParse(ingreso, out numero2))
              Console.WriteLine("\nERROR, no ha ingresado un numero.\n");
          } while (!double.TryParse(ingreso, out numero2));
          if (numero2 < 0)
            Console.WriteLine("\nERROR, el numero ingresado es menor a 0\n");
        } while (numero2 < 0);
        resultado = Calculadora.Calcular(numero1, numero2, operante);
        Console.Clear();
        if(resultado != 0 && operante != '/')
        Console.WriteLine("\nEl resultado de la operación es de: {0}\n", resultado);
        else
          Console.WriteLine("\nNo se puede dividir por 0");
        Console.WriteLine("\n¿DESEA CONTINUAR? (S/N)");
      operante = Console.ReadKey().KeyChar;
    }while(operante == 's');
  }
    }
  }

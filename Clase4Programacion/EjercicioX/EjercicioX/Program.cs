using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioX
{
  class Program
  {
    static void Main(string[] args)
    {
            string nombre;
            string apellido;
            string ingresoSueldo;
            int sueldoBruto;
            Console.WriteLine("Ingrese un nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese un sueldo: ");
            ingresoSueldo = Console.ReadLine();
            int.TryParse(ingresoSueldo, out sueldoBruto);
            Empleado e1 = new Empleado(nombre, apellido, sueldoBruto);
            e1.CalcularNeto(sueldoBruto);
            e1.Mostrar();
            Console.ReadKey();
    }
  }
}

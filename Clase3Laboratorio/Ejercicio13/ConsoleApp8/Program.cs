using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS = System.Console;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int ingresoEntero;
            Cuadrado cuadrado = new Cuadrado();
            double salida;
            do
            {
                do
                {
                    CS.WriteLine("Ingrese un numero");
                    ingreso = CS.ReadLine();
                } while(!int.TryParse(ingreso, out ingresoEntero));

            }while(!Cuadrado.PotenciarNumero(ingresoEntero, out salida));

            CS.WriteLine(salida.ToString());
            CS.ReadLine();
        }
    }
}

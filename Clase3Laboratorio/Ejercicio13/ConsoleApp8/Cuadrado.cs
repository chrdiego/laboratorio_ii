using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Cuadrado
    {
        public static bool PotenciarNumero(int numero, out double potencia)
        {
            potencia = 0;
            if (numero >0) {
                potencia = Math.Pow(numero, 2);            
                return true;
            }
            else
                return false;            
        }

    }
}

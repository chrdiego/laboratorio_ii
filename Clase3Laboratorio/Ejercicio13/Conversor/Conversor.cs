using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string resultado = "";
            do
            {
                resultado = (num % 2) + resultado;
                num = (int)num / 2;
            } while (num > 0);
            return resultado;
        }

        public static double BinarioDecimal(string num)
        {
            double resultado = 0; 
            for(int i = 0; i < num.Length; i++)
            {
                resultado += int.Parse(num[i].ToString()) * (Math.Pow(2,num.Length -1 - i));
            }
            return resultado;

        }

        public static double BinarioDecimalFacil(string num)
        {

            return Convert.ToInt64(num, 2);
        }

        public static string DecimalBinarioFacil(double num)
        {
            return Convert.ToString(Convert.ToByte(num), 2);
        }
    }
}

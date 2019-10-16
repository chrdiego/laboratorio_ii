using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region CONSTRUCTORES
        public Numero() // public Numero() : this(0) { }
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }


        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion
        #region MÉTODOS
        private double ValidarNumero(string strNumero)
        {
            double num = 0;
            if (double.TryParse(strNumero, out num))
            {
                return num;
            }
            else
                return 0;
        }

        public string BinarioDecimal(string binario)
        {
            double resultado = 0;
            for (int i = 0; i < binario.Length; i++)
            {
                resultado += int.Parse(binario[i].ToString()) * (Math.Pow(2, binario.Length - 1 - i));
            }
            return resultado.ToString();
        }

        public string DecimalBinario(double numero)
        {
            return Convert.ToString(Convert.ToByte(numero), 2);
        }

        public string DecimalBinario(string numero)
        {
            double num;
            if (double.TryParse(numero, out num))
            {
                return DecimalBinario(num);
            }
            else
                return "Valor inválido";
        }
        #endregion
        #region OPERADORES
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            else
                return double.MinValue;
        }
        #endregion
    }
}

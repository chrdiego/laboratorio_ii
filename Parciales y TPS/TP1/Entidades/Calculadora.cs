using System;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            if (num1 != null && num2 != null && operador != null)
            {
                operador = ValidarOperador(operador);
                switch (operador)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                }
            }
            return resultado;
        }

        private static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "/" || operador == "-" || operador == "*")
            {
                return operador;
            }
            else
                return "+";
        }
    }
}

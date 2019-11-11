using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    public static class CantidadDeDigitos
    {
        public static long Metodo(this string digitos)
        {
            long contador = 0;
            for (int i = 0; i < digitos.Length; i++)
            {
                if (digitos[i] >= 0 && digitos[i] <= 9)
                    contador++;
            }
            return contador;
        }
    }
}

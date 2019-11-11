using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ExtendidoString
    {
        public static string Metodo(this string cadena)
        {
            int contador = 0;
            for(int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ',' || cadena[i] == '.' || cadena[i] == ':' || cadena[i] == ';')
                    contador++;
            }
            return $"Cantidad de signos de puntuacion: {contador}";
        }
    }
}

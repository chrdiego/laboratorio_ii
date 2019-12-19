using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = (float)unidades;
        }

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int num = texto.Count();
            this.tamanioMina = this.tamanioMina - (num * 0.1f);
            return new EscrituraWrapper(texto, Color);
        }

       public bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LAPIZ: " + this.Color);
            sb.AppendLine("TAMAÑO DE MINA: " + this.tamanioMina);
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            int num = texto.Count();
            this.tinta = this.tinta - (0.3f * num);
            return new EscrituraWrapper(texto, Color);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BOLÍGRAFO COLOR: " + this.colorTinta);
            sb.AppendLine("NIVEL DE TINTA: " + this.tinta);
            return sb.ToString();
        }
    }
}

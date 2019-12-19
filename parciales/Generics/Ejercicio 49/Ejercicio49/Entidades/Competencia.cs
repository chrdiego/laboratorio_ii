using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private short cantidadComeptidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public List<VehiculoDeCarrera> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadComeptidores; 
            }
            set
            {
                this.cantidadComeptidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this[i];
            }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadComeptidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("COMPETENCIA: ");
            sb.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            sb.AppendLine("Cantidad competidores: " + this.cantidadComeptidores);
            return sb.ToString();
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random random = new Random();
            if (c.cantidadComeptidores > c.Competidores.Count && c != a)
            {
                a.EnCompetencia = true;
                a.CantidadCombustible = (short)random.Next(15, 100);
                a.VueltasRestantes = c.cantidadVueltas;
                c.Competidores.Add(a);
                return true;
            }
            else
                return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            int contador = 0;
            foreach(AutoF1 auto in c.Competidores)
            {
                if (auto == a)
                {
                    c.competidores.RemoveAt(contador);
                    return true;
                }
                contador++;
            }
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if(c.Tipo )
            foreach(AutoF1 auto in c.Competidores)
            {
                if (auto == a)
                    return true;
            }
                return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }


    }
}

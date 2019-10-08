using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        private DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length <= 6)
                    this.patente = value;
                else
                    this.patente = "inválida";
            }
        }

        public abstract string ConsultarDatos();

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public override string ToString()
        {
            return String.Format("Patente {0}", this.Patente);
        }

        public virtual string ImprimirTicket()
        {
            return ToString() + " Ingreso: " + this.ingreso;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(!(v1 is null) && !(v2 is null))
            {
                if (v1.Patente.Equals(v2.Patente))
                    return true;
                else
                    return false;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private int valorHora;

        private Moto(string patente) : base (patente) 
        {
            this.ruedas = 2;
            this.valorHora = 30;
        }
        public Moto(string patente, int cilindrada) : this (patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this (patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this (patente, cilindrada, ruedas)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
           return ToString() + " Cilindrada: " + this.cilindrada + " Ruedas: " + this.ruedas + " Valor hora: " + this.valorHora;
        }

        public override bool Equals(object obj)
        {
            if (base.Patente.Equals(obj))
                return true;
            else
                return false;
        }

        public override string ImprimirTicket()
        {
            return base.ImprimirTicket();
        }
    }
}

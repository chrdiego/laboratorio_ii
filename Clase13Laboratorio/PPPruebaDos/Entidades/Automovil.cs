using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;

        private Automovil(string patente) : base(patente)
        {
            this.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : this (patente)
        {
            this.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : base (patente)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            return base.ToString() + " Color: " + this.color + "Valor de hora: " + this.valorHora;
        }

        public override bool Equals(object obj)
        {
            if (this.Patente.Equals(obj))
                return true;
            else return false;
        }

        public override string ImprimirTicket()
        {
            return base.ImprimirTicket();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private int valorHora = 70;

        private PickUp(string patente) : base (patente)
        {
        }

        public PickUp(string patente, string modelo) : this (patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora) : this (patente, modelo)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            return base.ToString() + " Modelo: " + this.modelo + " Valor hora: " + this.valorHora;
        }

        public override string ImprimirTicket()
        {
            return base.ImprimirTicket() + " Modelo: " + this.modelo + " Valor hora: " + this.valorHora;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}

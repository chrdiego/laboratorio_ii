using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region propiedades
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.altura;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
        {
            this.peso = this.Peso;
            this.altura = this.Altura;
            this.posicion = this.Posicion;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + "Altura: " + this.Altura + "\nPeso: " + this.Peso + "\nPosicion: " + this.Posicion;
        }

        public new bool ValidarAptitud()
        {
            if (this.ValidarEstadoFisico() == true && this.Edad < 40)
                return true;
            else
                return false;
        }

        public bool ValidarEstadoFisico()
        {
            double imc = 0;
            imc = this.Peso / Math.Pow(this.Altura, 2);
            if (imc >= 18.5f && imc <= 25)
                return true;
            else
                return false;
        }

    }
}

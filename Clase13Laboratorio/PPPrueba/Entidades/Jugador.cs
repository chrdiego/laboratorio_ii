using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        protected float altura;
        protected float peso;
        protected Posicion posicion;


        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }


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
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }


        public new string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine("Altura: " + Altura);
            retorno.AppendLine("Peso: " + Peso);
            retorno.AppendLine("Posicion: " + Posicion);
            return retorno.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float imc = (Peso / (float)(Math.Pow(Altura, 2)));
            if (imc > 18.5 && imc < 25)
            {
                retorno = true;
            }
            return retorno;
        }


        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if (ValidarEstadoFisico() == true && Edad < 40)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}

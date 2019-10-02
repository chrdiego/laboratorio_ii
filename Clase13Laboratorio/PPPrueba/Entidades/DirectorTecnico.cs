using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        protected int añosDeExperiencia;
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosDeExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosDeExperiencia = añosDeExperiencia;
        }

        protected int AñosDeExperiencia
        {
            get
            {
                return this.añosDeExperiencia;
            }

            set
            {
                this.añosDeExperiencia = value;
            }
        }

        public override string Mostrar()
        {
            return base.Mostrar() + "\nAños experiencia: " + this.AñosDeExperiencia;
        }


        public override bool ValidarAptitud()
        {
            if (Edad < 65 && AñosDeExperiencia >= 2)
                return true;
            else
                return false;
        }
    }
}

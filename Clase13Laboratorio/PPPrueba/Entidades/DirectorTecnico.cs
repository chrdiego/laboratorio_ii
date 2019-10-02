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


        public new string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine("Años de Exp: " + AñosDeExperiencia);
            return retorno.ToString();
        }


        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if (Edad < 65 && AñosDeExperiencia >= 2)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}

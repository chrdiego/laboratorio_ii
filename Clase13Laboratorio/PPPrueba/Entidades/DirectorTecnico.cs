using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;
        #region propiedades
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        #endregion

        public DirectorTecnico(string nombre, string apellido, int dni, int edad, int añosExperiencia) : base (nombre, apellido, edad, dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + "\nAños experiencia: " + this.AñosExperiencia;
        }

        public new bool ValidarAptitud()
        {
            if (this.Edad <= 65 && this.AñosExperiencia >= 2)
                return true;
            else
                return false;
        }



    }
}

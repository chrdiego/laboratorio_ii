using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        #region propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        #endregion

#region metodos

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\nApellido: {1}\nEdad: {2}\nDNI: {3}\n", this.Nombre, this.Apellido,this.Edad,this.Dni);
            return sb.ToString();
        }

        public bool ValidarAptitud()
        {
            return true;
        }
#endregion
    }
}

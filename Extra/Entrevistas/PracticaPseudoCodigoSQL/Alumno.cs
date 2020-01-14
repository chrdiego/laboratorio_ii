using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPseudoCodigoSQL
{
    public class Alumno
    {
        private string apellido;
        private string nombre;
        private int nota;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Nota
        {
            get
            {
                return this.nota;
            }
            set
            {
                this.nota = value;
            }
        }

        public Alumno(string nombre, string apellido, int nota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nota = nota;
        }
    }
}

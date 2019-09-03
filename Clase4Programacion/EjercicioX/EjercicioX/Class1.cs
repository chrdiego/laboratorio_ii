using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioX
{
  class Empleado
  {
        string nombre;
        string apellido;
        int SueldoBruto;
        int SueldoNeto;
        int Jubilacion;
        int Ley;
        int ObraSocial;

        public Empleado()
        {
            this.nombre = "Carlos";
            this.apellido = "Perez";
            this.SueldoBruto = 0;
            this.SueldoNeto = 0;
            this.Jubilacion = 0;
            this.Ley = 0;
            this.ObraSocial = 0;
        }
        public Empleado(string nombre, string apellido, int sueldoBruto) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.SueldoBruto = sueldoBruto;
        }
        public Empleado(string nombre, string apellido, int sueldoBruto, int sueldoNeto, int jubilacion, int ley, int obraSocial) : this(nombre, apellido, sueldoBruto)
        {
            this.SueldoNeto = sueldoNeto;
            this.Jubilacion = jubilacion;
            this.Ley = ley;
            this.ObraSocial = obraSocial;
        }

        public void CalcularNeto(int sueldoBruto)
        {
            this.Jubilacion = sueldoBruto * 3 / 100;
            this.Ley = sueldoBruto * 3 / 100;
            this.ObraSocial = sueldoBruto * 3 / 100;
            this.SueldoNeto = sueldoBruto - this.Jubilacion - this.Ley - this.ObraSocial;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", this.nombre, this.apellido, this.SueldoBruto, this.SueldoNeto, this.Ley, this.Jubilacion, this.ObraSocial);
        }
    }
}

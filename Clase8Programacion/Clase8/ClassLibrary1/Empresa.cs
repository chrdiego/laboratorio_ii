using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public class Empresa
  {
    List<Empleado> nomina;
    string razonSocial;
    string direccion;
    float ganancias;

     private Empresa()
    {
      this.nomina = new List<Empleado>();
    }

    public Empresa(string razonSocial, string direccion, float ganancias) : this()
    {
      this.razonSocial = razonSocial;
      this.direccion = direccion;
      this.ganancias = ganancias;
    }

    public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            foreach (Empleado e in empresa.nomina)
            {
                if (empleado == e)
                    return empresa;
            }
            empresa.nomina.Add(empleado);
            return empresa;
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
            set
            {
                this.razonSocial = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public float Ganancias
        {
            get
            {
                return this.ganancias;
            }
            set
            {
                this.ganancias = value;
            }
        }

        public string MostrarEmpresa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados: \n", this.razonSocial, this.direccion, this.ganancias, this.nomina.Count);
            foreach (Empleado e in this.nomina)
                sb.AppendLine(e.Mostrar());
            return sb.ToString();

        }
  }
}

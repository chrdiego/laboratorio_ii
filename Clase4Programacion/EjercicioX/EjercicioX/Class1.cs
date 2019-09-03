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
    double SueldoBruto;
    double SueldoNeto;
    double Ley19032;
    double ObraSocial;

    public Empleado()
    {
      this.nombre = "Juan";
      this.apellido = "Carlos";
      this.SueldoBruto = 0;
      this.SueldoNeto = 0;
      this.Ley19032 = 0;
      this.ObraSocial = 0;
    }

    public Empleado(string nombre, string apellido, double sueldoBruto) : this ()
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.SueldoBruto = sueldoBruto;
    }

    public Empleado(string nombre, string apellido, double sueldoBruto, double sueldoNeto, double ley, double obrasocial)
      : this (nombre, apellido, sueldoBruto)
    {
      this.SueldoNeto = sueldoNeto;
      this.Ley19032 = ley;
      this.ObraSocial = obrasocial;
    }
    public Empleado CalcularNeto(double bruto)
    {
      double SueldoBruto = bruto;
      double ley = 0;
      double obraSocial = 0;
      double SueldoNeto = 0;
      double jubilacion = 0;
      ley = SueldoBruto * 3 / 100;
      obraSocial = SueldoBruto * 3 / 100;
      jubilacion = SueldoBruto * 3 / 100;
      SueldoNeto = SueldoBruto - ley - obraSocial - jubilacion;
      return Empleado(this.nombre, this.apellido, this.SueldoBruto, SueldoNeto, ley, obraSocial);

    }
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Nombre: {0} - Apellido {0} - Sueldo Bruto: {0} - Sueldo Neto: {0} - Ley: {0} - Obra social: {0}", this.nombre, this.apellido, this.SueldoBruto, this.SueldoNeto, this.Ley19032, this.ObraSocial);
      return sb.ToString();
    }
  }
}

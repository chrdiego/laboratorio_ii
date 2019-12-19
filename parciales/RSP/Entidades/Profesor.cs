using System.Collections.Generic;
using System.Text;

namespace Entidades
{

    public class Profesor<TUniversitario> : Universitario where TUniversitario : Universitario, IUniversitario
  {
        private EMateria materia;
        private List<TUniversitario> alumnos;

        public Profesor(int legajo, string nmbr)
            : base(legajo, nmbr)
        {
            this.alumnos = new List<TUniversitario>();
        }

        public Profesor(int legajo, string nombr, EMateria mat)
            : this(legajo, nombr)
        {
        this.materia = mat;
        }

        public List<TUniversitario> Alumnos
        {
            get
            {
                return this.alumnos;
            }
        }

        public EMateria Materia
        {
            get
            {
                return this.materia;
            }
        }
        public static bool operator -(Profesor<TUniversitario> profesor, TUniversitario alumno)
    {
      int i = 0;
      if (alumno is Alumno)
      {
        foreach(TUniversitario a in profesor.Alumnos)
        {
          if(a.Legajo == alumno.Legajo)
          {
            profesor.alumnos.RemoveAt(i);
            return true;
          }
          i++;
        }
      }

      return false;
    }


        public static Profesor<TUniversitario> operator +(Profesor<TUniversitario> profesor, TUniversitario alumno)
        {
            
            if (alumno is Alumno)
            {
        if (profesor != alumno)
        {
          profesor.alumnos.Add(alumno);
          return profesor;

        }
        else
          throw new AlumnoException();
            }

            return profesor;
        }

        public static bool operator ==(Profesor<TUniversitario> profesor, TUniversitario alumno)
        {
            foreach (TUniversitario alumnoProf in profesor.alumnos)
            {
                if (alumno.Legajo == alumnoProf.Legajo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Profesor<TUniversitario> profesor, TUniversitario alumno)
        {
            return !(profesor == alumno);
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Alumno");
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Tipo: {materia}");

            foreach (TUniversitario satelite in this.alumnos)
            {
                retorno.AppendLine(satelite.ToString());
            }

            return retorno.ToString();
        }
    }
}

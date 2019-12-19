using System;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Alumno : Universitario, IUniversitario
    {
        public event AlumnoDelegate AlumnoEvent;
        private float notaParcial;
        private Thread hiloExamen;

        public Thread HiloExamen
        {
            get
            {
                return this.hiloExamen;
            }

            set
            {
                this.hiloExamen = value;
            }
        }

        public float NotaParcial
        {
            set => notaParcial = value;
        }

        public Alumno() { }

        public Alumno(int legajo, string nombre)
            : base(legajo, nombre) { }

        public void DarExamen()
        {
            Thread.Sleep(new Random().Next(1000, 3000));
        }

        public void InvocarEvent()
        {
          AlumnoEvent.Invoke();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Alumno");
            sb.AppendLine(Mostrar());
            sb.AppendLine($"Nota: {notaParcial}");

            return sb.ToString();
        }

        public void CalcularNota()
        {
            this.notaParcial = new Random().Next(0, 3);
        }

        public bool TieneManejadores()
        {
            return this.AlumnoEvent != null;
        }
    }
}

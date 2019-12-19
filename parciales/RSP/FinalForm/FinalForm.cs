using System;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace Utn
{
    public partial class FinalForm : Form
    {
        private Profesor<Alumno> profesor;

        public FinalForm()
        {
            InitializeComponent();
            profesor = new Profesor<Alumno>(1, "Demian");
        }
        
        public void MostrarMensaje()
        {
            MessageBox.Show("Un alumno finalizó examen...");
        }

        private void btnEscapaProfesor_Click(object sender, EventArgs e)
        {
          foreach(Alumno a in profesor.Alumnos)
      {
        if (a.TieneManejadores())
        {
          MessageBox.Show("Vamos vamos entregeeeeen...!");
          break;
        }
        else
        {
          this.Close();
        }
      }
      if (profesor.Alumnos.Count == 0)
        this.Close();
        }

        private void BtnInitExam_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnCargarEventos_Click(object sender, EventArgs e)
        {
      int i = 0;
          foreach(Alumno a in profesor.Alumnos)
      {
        if (a.HiloExamen is null)
        {
          Thread t1 = new Thread(a.CalcularNota);
          a.HiloExamen = t1;
          t1.Start();
        }
        if (!a.TieneManejadores())
        {
          a.AlumnoEvent += this.MostrarMensaje;
          a.CalcularNota();
          i++;
        }
        MessageBox.Show("Se le asignó a " + i + " alumnos manejadores");
      }
        }

        private void btnAgrAlumno_Click(object sender, EventArgs e)
        {
      int salida = 0;
      int.TryParse(txLegajo.Text, out salida);
      Alumno a = new Alumno(salida, txNombre.Text);
      profesor += a;
        }
    }
}

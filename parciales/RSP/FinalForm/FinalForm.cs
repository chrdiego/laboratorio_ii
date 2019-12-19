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
        
        public void MostrarMensaje  ()
        {
            MessageBox.Show("Un alumno finalizó examen...");
        }

        private void btnEscapaProfesor_Click(object sender, EventArgs e)
        {
        }

        private void BtnInitExam_Click(object sender, EventArgs e)
        {
        }

        private void BtnCargarEventos_Click(object sender, EventArgs e)
        {
        }

        private void btnAgrAlumno_Click(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelotitas
{
    public partial class FormJuego : Form
    {
        public int puntos;
        public FormJuego()
        {
            InitializeComponent();
            puntos = 0;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            PelotitaControl pelotita = new PelotitaControl();
            pelotita.setImage(Properties.Resources.pelotita);
            pelotita.Top = r.Next(this.Height - pelotita.Height); 

            Thread hilo = new Thread(new ParameterizedThreadStart(pelotita.Mover));
            pelotita.Hilo = hilo;
            pelotita.eventoEliminar += this.AumentarPuntos;
            pelotita.eventoFinalizar += this.EliminarTodasLasPelotitas;
            pelotita.eventoFinalizar += this.MostrarMensaje;


            this.Controls.Add(pelotita);
            hilo.Start(this.Width);
        }

        public void AumentarPuntos()
        {
            this.puntos++;
        }

        public void EliminarTodasLasPelotitas()
        {
            foreach(Control control in this.Controls)
            {
                Application.DoEvents();
                if (control is PelotitaControl)
                    ((PelotitaControl)control).Eliminar();
            }
        }

        public void MostrarMensaje()
        {
            MessageBox.Show($"TOTAL PUNTOS: {this.puntos}");
        }
    }
}

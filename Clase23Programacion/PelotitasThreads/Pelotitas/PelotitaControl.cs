using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pelotitas
{
    public delegate void DelegadoPelotita();

    public partial class PelotitaControl : UserControl
    {
        public Thread hilo;
        public event DelegadoPelotita eventoEliminar;
        public event DelegadoPelotita eventoFinalizar;
        public PelotitaControl()
        {
            InitializeComponent();
            eventoEliminar += Eliminar;
        }

        public Thread Hilo
        {
            set
            {
                this.hilo = value;
            }
        }

        public void setImage(Bitmap imagen)
        {
            this.pictureBox1.Image = imagen;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Mover(object WidthPantalla)
        {

            while(this.Left < ((int)WidthPantalla - this.Width))
            {
                Thread.Sleep(50);
                Application.DoEvents();
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.Left += 5;
                    });
                }
                else
                {
                    this.Left += 30;
                }
            }
            //Si sale del while es porque llegó al final de la pantalla
            //por lo tanto disparamos el evento Finalizar
            eventoFinalizar();
        }

        public void Eliminar()
        {
            if (this.hilo.IsAlive)
                this.hilo.Abort();

            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.Hide();
                });
            }
            else
            {
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            eventoEliminar();
        }

        
    }
}

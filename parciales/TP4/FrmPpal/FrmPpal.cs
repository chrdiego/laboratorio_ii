using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmPpal
{
    public partial class FrmPpal : Form
    {
        Correo correo;
        public FrmPpal()
        {
            InitializeComponent();
            correo = new Correo();
        }

        private void ActualizarEstados()
        {
            this.lstEstadoEntregado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoIngresado.Items.Clear();

            foreach(Paquete p in this.correo.Paquetes)
            {
                switch(p.Estado)
                {
                    case EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(p);
                        break;
                    case EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(p);
                        break;
                    case EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(p);
                        break;
                }
            }
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
                this.ActualizarEstados();
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(!object.Equals(elemento, null))
            {
                this.rtbMostrar.Clear();
                rtbMostrar.Text = elemento.MostrarDatos(elemento);
                GuardaString.Guardar(elemento.MostrarDatos(elemento), "salida.txt");
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete p = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
                this.correo += p;
                p.InformaEstado += this.paq_InformaEstado;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.ActualizarEstados();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void MostrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}

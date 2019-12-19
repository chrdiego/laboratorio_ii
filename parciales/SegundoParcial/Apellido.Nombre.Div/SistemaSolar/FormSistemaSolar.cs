using System;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace SistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        private Planeta<Satelite> planeta;
        public FormSistemaSolar()
        {
            InitializeComponent();
            planeta = new Planeta<Satelite>(20, 20, "Júpiter");
            FormClosed += finHilos;
        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {
            if(this.planeta.HiloRotacion is null)
            {
                Thread t2 = new Thread(this.planeta.RunEvntRotar);
                this.planeta.HiloRotacion = t2;
                this.planeta.HiloRotacion.Start();
            }
            if (!this.planeta.NecesitaInvocacion())
            {
                this.planeta.AstroEvent += this.MostrarMensaje;
            }
            this.planeta.RunEvntRotar();
        }


        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {
            foreach(Satelite item in this.planeta.Satelites)
            {
                if(item.HiloOrbita is null)
                {
                    Thread t1 = new Thread(this.planeta.RunEvntOrb);
                    this.planeta.HiloOrbita = t1;
                    t1.Start();
                }
                if (!item.NecesitaInvocacion())
                {
                    item.AstroEvent += this.MostrarMensaje;
                }
                item.RunEvntOrb();
            }
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            int orbita;
            int rotacion;
            int.TryParse(txOrbita.Text, out orbita);
            int.TryParse(txRota.Text, out rotacion);
            if (orbita >= 1 && rotacion >= 1)
            {
                Satelite s = new Satelite(orbita, rotacion, txNombre.Text);
                this.planeta += s;
                if(this.planeta == s)
                {
                    SateliteDB sb = new SateliteDB();
                    try
                    {
                        sb.Guardar(s);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Planeta agregado a la base de datos");
                }

            }
        }

        private void finHilos(object sender, EventArgs e)
        {
            if (this.planeta.HiloOrbita != null && this.planeta.HiloOrbita.IsAlive)
                this.planeta.HiloOrbita.Abort();

            if (this.planeta.HiloRotacion != null && this.planeta.HiloRotacion.IsAlive)
                this.planeta.HiloRotacion.Abort();

            foreach (Satelite item in this.planeta.Satelites)
            {
                if (item.HiloOrbita != null && item.HiloOrbita.IsAlive)
                    item.HiloOrbita.Abort();

                if (item.HiloRotacion != null && item.HiloRotacion.IsAlive)
                    item.HiloRotacion.Abort();
            }
        }

        private void FormSistemaSolar_Load(object sender, EventArgs e)
        {
        }
    }
}

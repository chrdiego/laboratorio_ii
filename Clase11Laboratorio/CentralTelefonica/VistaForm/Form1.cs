using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace VistaForm
{
    public partial class Central : Form
    {
        public Centralita centralita;
        public Central()
        {
            InitializeComponent();
        }

        private void Central_Load(object sender, EventArgs e)
        {
            centralita = new Centralita();
        }

        private void BtnLlamada_Click(object sender, EventArgs e)
        {
            Form2 llamadaForm = new Form2(centralita);
            llamadaForm.Show();
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(centralita, Llamada.TipoLlamada.Todas);
            form.Show();
        }

        private void BtnLocal_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(centralita, Llamada.TipoLlamada.Local);
            form.Show();
        }

        private void BtnProvincial_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(centralita, Llamada.TipoLlamada.Provincial);
            form.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

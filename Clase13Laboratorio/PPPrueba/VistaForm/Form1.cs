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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private DirectorTecnico dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numDNI.Value, (int)numExp.Value);
            MessageBox.Show("¡Se ha creado el DT!");
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (dt == null)
                MessageBox.Show("Aún no se ha creado el DT");
            if (dt.ValidarAptitud() == true)
                MessageBox.Show("El DT es apto");
            else if (dt.ValidarAptitud() == false)
                MessageBox.Show("El DT no es apto");
            txtNombre.Text = "";
            txtApellido.Text = "";
            numDNI.Value = 0;
            numEdad.Value = 0;
            numExp.Value = 0;
        }
    }
}

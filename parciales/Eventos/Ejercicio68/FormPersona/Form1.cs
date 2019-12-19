using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPersona
{
    public partial class Form1 : Form
    {
        private Persona persona;
        public Form1()
        {
            InitializeComponent();
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio, "Mensaje", MessageBoxButtons.OK);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(this.persona == null)
            {
                this.persona = new Persona();
                persona.EventoString += NotificarCambio;
                persona.Nombre = textBox1.Text;
                persona.Apellido = textBox2.Text;
            }
        }
    }
}

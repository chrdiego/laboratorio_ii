using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Clase8
{
  public partial class Form2 : Form
  {
        Empresa empresa;
        public Empresa Empresa
        {
            get
            {
                return this.empresa;
            }
        }
        public Form2(Empresa empresa)
         {
             InitializeComponent();
            this.empresa = empresa;
         }
       

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            float ganancias = float.Parse(this.mtxtGanancias.Text);
            if (this.empresa == null)
                this.empresa = new Empresa(this.txtRazonSocial.Text, this.txtDireccion.Text, ganancias);
            else
            {
                this.empresa.RazonSocial = txtRazonSocial.Text;
                this.empresa.Direccion = txtDireccion.Text;
                this.empresa.Ganancias = ganancias;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}

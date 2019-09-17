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
  public partial class Form1 : Form
  {
    Empresa empresa;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      cmbPuesto.DataSource = Enum.GetValues(typeof(Empleado.EPuestoJerarquico));
            btnEmpresa_Click(sender, e);
        }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      txtNombre.Text = "";
      txtApellido.Text = "";
      mtxtLegajo.Text = "";
      cmbPuesto.Text = "";
      mtxtSalario.Text = "";
      rtxtConsola.Text = "";
    }

    private void btnAgregarItem_Click(object sender, EventArgs e)
    {
            Empleado.EPuestoJerarquico puesto;
            int salario;
            // Controlo que los valores ingresados respeten el tipo de dato
            if (!Enum.TryParse<Empleado.EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out puesto))
            {
                MessageBox.Show("Error en el combo de Puesto del empleado.");
                return;
            }
            if (!Int32.TryParse(mtxtSalario.Text.Substring(1, mtxtSalario.Text.Length - 1), out salario))
            {
                MessageBox.Show("Error en el salario del empleado.");
                return;
            }
            // Agrego el empleado a la empresa
            Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text, puesto, salario);
            this.empresa += empleado;
            // Muestro la empresa por pantalla
            rtxtConsola.Text = this.empresa.MostrarEmpresa();
        }

    private void btnEmpresa_Click(object sender, EventArgs e)
    {
      Form2 form = new Form2(this.empresa);
      form.ShowDialog();
            if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                this.empresa = form.Empresa;
            else
                this.Close();
    }
  }
}

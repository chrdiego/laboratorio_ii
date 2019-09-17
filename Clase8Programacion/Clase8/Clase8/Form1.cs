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
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      cmbPuesto.DataSource = Enum.GetValues(typeof(Empleado.EPuestoJerarquico));
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
      int legajo;
      Empleado.EPuestoJerarquico puesto;
      Enum.TryParse<Empleado.EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out puesto);
      if (int.TryParse(mtxtSalario.Text, out legajo) == false)
      {
        mtxtSalario.Text = "";
      }

      Empleado nuevoEmpleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text, puesto, legajo);
      rtxtConsola.Text = nuevoEmpleado.Mostrar(nuevoEmpleado);
      
    }

    private void btnEmpresa_Click(object sender, EventArgs e)
    {
      Form2 form = new Form2();
      form.Show();
    }
  }
}

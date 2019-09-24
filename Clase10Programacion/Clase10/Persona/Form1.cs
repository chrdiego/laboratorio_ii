using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase10;

namespace Persona
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      // this.cmbTipoEmpleado.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.cmbTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTipoEmpleado.Items.Add("Empleado");
      this.cmbTipoEmpleado.Items.Add("Jefe");
      this.cmbTipoEmpleado.Items.Add("Vendedor");
    }

    private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
    {
        while(cmbTipoEmpleado.SelectedIndex == 1)
      {
        this.lblBono.Visible = true;
        this.txtBono.Visible = true;
      }
        while(cmbTipoEmpleado.SelectedIndex == 2)
      {
        this.lblObjetivo.Visible = true;
        this.txtObjetivo.Visible = true;
      }
    }
  }
}

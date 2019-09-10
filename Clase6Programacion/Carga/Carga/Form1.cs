using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carga
{
  public partial class Form1 : Form
  {
    public Persona[] personas;
    public Form1()
    {
      InitializeComponent();
      personas = new Persona[3];
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      if(DialogResult.Yes == MessageBox.Show("¿Estás seguro?", "¡Atención!",MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
      int dni;
      if (int.TryParse(this.textDNI.Text, out dni))
      {
        Persona unaPersona = new Persona(this.textNombre.Text, this.textApellido.Text, dni);
        for (int i = 0; i < personas.Length; i++)
        {
          if (personas[i] == null)
          {
            personas[i] = unaPersona;
            break;
          }
        }
      }
      else
        MessageBox.Show("DNI INVÁLIDO");
      Limpiar();
      }
    }

    public void Limpiar()
    {
      this.textNombre.Text = "";
      this.textApellido.Text = "";
      this.textDNI.Text = "";
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Limpiar();
    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
      FrmMostrar frmMostrar = new FrmMostrar();
      frmMostrar.Show(this);
    }

    public string ObtenerSexo()
    {
      /*
      foreach(Control item in this.groupBox.Controls)
      {
        if (item is RadioButton && ((RadioButton)item).Checked)
          return item.Text;
      }
      */
      if (this.radioButton1.Checked)
        return "Masculino";
      if (this.radioButton2.Checked)
        return "Femenino";
      else
        return "Otro";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Items.Add("Buenos Aires");
      this.comboBox1.Items.Add("CABA");
      this.comboBox1.SelectedIndex = -1;
      this.radioButton1.Checked = true;
      //this.chbVive.ThreeState = true;
      //this.chbVive.CheckState == CheckState.Indeterminate;
    }
  }
}

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
      frmMostrar.Show();

    }

    private void textApellido_TextChanged(object sender, EventArgs e)
    {

    }
  }
}

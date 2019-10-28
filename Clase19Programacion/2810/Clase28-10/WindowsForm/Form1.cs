using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace WindowsForm
{
  public partial class Form1 : Form
  {
    private static List<Mensaje> mensajes;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      mensajes = new List<Mensaje>();
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      if (txtUsuario.Text != "" && txtMensaje.Text != "")
      {
        Mensaje mensaje = new Mensaje(txtUsuario.Text, txtMensaje.Text);
        mensajes.Add(mensaje);
        listMensajes.DataSource = mensajes;
        txtUsuario.Text = "";
        txtMensaje.Text = "";
      }
      else
        MessageBox.Show("Ingrese datos.");
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      StreamWriter sw = new StreamWriter(@"C:\Users\alumno\Desktop\2810\archivo.log", true);
      foreach (Mensaje mensaje in mensajes)
      {
        sw.WriteLine(mensaje);
      }
      sw.Close();
    }
  }
}

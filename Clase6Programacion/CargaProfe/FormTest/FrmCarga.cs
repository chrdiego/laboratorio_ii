using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class FrmCarga : Form
    {
        public Persona[] personas;
        public FrmCarga()
        {
            InitializeComponent();
            personas = new Persona[3];
        }

        private void FrmCarga_Load(object sender, EventArgs e)
        {
            this.cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbProvincia.Items.Add("Buenos Aires");
            this.cmbProvincia.Items.Add("CABA");
            this.cmbProvincia.SelectedIndex = 0;
            this.rdbMasculino.Checked = true;
            //this.chbVive.ThreeState = true;
            //this.chbVive.CheckState == CheckState.Indeterminate;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Esta seguro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int dni;
                if(int.TryParse(this.txtDni.Text, out dni))
                {
                    bool vive = CheckState.Checked == this.chbVive.CheckState;
                    string sexo = this.ObtenerSexo();
                    string provincia = this.cmbProvincia.SelectedItem.ToString();
                    Persona unaPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text, dni, provincia, vive, sexo);
                    for(int i = 0; i < personas.Length; i++)
                    {
                        if (personas[i] == null)
                        {
                            personas[i] = unaPersona;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DNI Inválido");
                }
                Limpiar();
            }
        }

        public string ObtenerSexo()
        {

            //foreach (Control item in this.groupBox.Controls)
            //{
            //    if (item is RadioButton && ((RadioButton)item).Checked)
            //        return item.Text;
            //}
            if (this.rdbMasculino.Checked)
                return "Masculino";
            if (this.rdbFemenino.Checked)
                return "Femenino";
            else
                return "Otro";
        }

        public void Limpiar()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
            } 

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar();
            //frmMostrar.ShowDialog(this);
            frmMostrar.Show(this);

        }

        
    }
}

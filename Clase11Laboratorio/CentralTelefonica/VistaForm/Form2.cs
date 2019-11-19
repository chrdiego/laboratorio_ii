using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace VistaForm
{
    public partial class Form2 : Form
    {
        public Centralita centralita;
        public Form2(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.txtNumero.Text = "Nro Destino";
            this.txtNumeroOrigen.Text = "Nro Origen";
        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracionRandom = (float)random.Next(1, 50);
            if (txtNumeroOrigen.Text != "Nro Origen")
            {
                if(txtNumero.Text.StartsWith("#"))
                {
                    Provincial.Franja franja;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                    Provincial nuevaLlamada = new Provincial(txtNumeroOrigen.Text, franja, duracionRandom, txtNumero.Text);
                    try
                    {
                        centralita = centralita + nuevaLlamada;
                        MessageBox.Show("Se realizó la llamada Provincial");
                    }
                    catch(CentralitaException ex)
                    {

                    }
                }
                else
                {
                    float costoRandom = random.Next(1, 5);
                    Local nuevaLlamada = new Local(txtNumeroOrigen.Text, duracionRandom, txtNumero.Text, costoRandom);
                    centralita = centralita + nuevaLlamada;
                    MessageBox.Show("Se realizó la llamada local");
                }
            }
        }

        public void Input(string input)
        {
            if(txtNumero.Text == "Nro Destino")
            {
                txtNumero.Text = "";
                cmbFranja.Visible = input is "#";
            }
            txtNumero.Text += input;
        }

        public void Limpiar()
        {
            txtNumero.Text = "Nro Destino";
            txtNumeroOrigen.Text = "Nro Origen";
            cmbFranja.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Input("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Input("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Input("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Input("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Input("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Input("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Input("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Input("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Input("9");
        }

        private void ButtonAsterisco_Click(object sender, EventArgs e)
        {
            Input("*");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Input("0");
        }

        private void ButtonNumeral_Click(object sender, EventArgs e)
        {
            Input("#");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

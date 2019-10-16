using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
        }



        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero(lblResultado.Text);
            lblResultado.Text = binario.DecimalBinario(lblResultado.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero decim = new Numero(lblResultado.Text);
            lblResultado.Text = decim.BinarioDecimal(lblResultado.Text);
        }
    }
}

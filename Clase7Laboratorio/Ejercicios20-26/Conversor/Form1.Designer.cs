namespace Conversor
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPeso = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtDolarPeso = new System.Windows.Forms.TextBox();
            this.txtPesoEuro = new System.Windows.Forms.TextBox();
            this.txtPesoDolar = new System.Windows.Forms.TextBox();
            this.txtPesoPeso = new System.Windows.Forms.TextBox();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EURO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PESO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOLAR";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(76, 63);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(91, 20);
            this.txtEuro.TabIndex = 4;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(76, 97);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(91, 20);
            this.txtDolar.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(76, 132);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(91, 20);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(173, 64);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(55, 19);
            this.btnEuro.TabIndex = 7;
            this.btnEuro.Text = "->";
            this.btnEuro.UseVisualStyleBackColor = true;
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(173, 97);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(55, 19);
            this.btnDolar.TabIndex = 8;
            this.btnDolar.Text = "->";
            this.btnDolar.UseVisualStyleBackColor = true;
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(173, 132);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(55, 19);
            this.btnPeso.TabIndex = 9;
            this.btnPeso.Text = "->";
            this.btnPeso.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "EURO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DOLAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PESO";
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(245, 19);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(91, 20);
            this.txtCotizacionEuro.TabIndex = 13;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(358, 19);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(91, 20);
            this.txtCotizacionDolar.TabIndex = 14;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(471, 19);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(91, 20);
            this.txtCotizacionPeso.TabIndex = 15;
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Location = new System.Drawing.Point(245, 63);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.ReadOnly = true;
            this.txtEuroEuro.Size = new System.Drawing.Size(91, 20);
            this.txtEuroEuro.TabIndex = 16;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Location = new System.Drawing.Point(358, 63);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.ReadOnly = true;
            this.txtEuroDolar.Size = new System.Drawing.Size(91, 20);
            this.txtEuroDolar.TabIndex = 17;
            // 
            // txtEuroPeso
            // 
            this.txtEuroPeso.Location = new System.Drawing.Point(471, 63);
            this.txtEuroPeso.Name = "txtEuroPeso";
            this.txtEuroPeso.ReadOnly = true;
            this.txtEuroPeso.Size = new System.Drawing.Size(91, 20);
            this.txtEuroPeso.TabIndex = 18;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Location = new System.Drawing.Point(245, 96);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.ReadOnly = true;
            this.txtDolarEuro.Size = new System.Drawing.Size(91, 20);
            this.txtDolarEuro.TabIndex = 19;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Location = new System.Drawing.Point(358, 96);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.ReadOnly = true;
            this.txtDolarDolar.Size = new System.Drawing.Size(91, 20);
            this.txtDolarDolar.TabIndex = 20;
            // 
            // txtDolarPeso
            // 
            this.txtDolarPeso.Location = new System.Drawing.Point(471, 96);
            this.txtDolarPeso.Name = "txtDolarPeso";
            this.txtDolarPeso.ReadOnly = true;
            this.txtDolarPeso.Size = new System.Drawing.Size(91, 20);
            this.txtDolarPeso.TabIndex = 21;
            this.txtDolarPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtPesoEuro
            // 
            this.txtPesoEuro.Location = new System.Drawing.Point(245, 131);
            this.txtPesoEuro.Name = "txtPesoEuro";
            this.txtPesoEuro.ReadOnly = true;
            this.txtPesoEuro.Size = new System.Drawing.Size(91, 20);
            this.txtPesoEuro.TabIndex = 22;
            // 
            // txtPesoDolar
            // 
            this.txtPesoDolar.Location = new System.Drawing.Point(358, 131);
            this.txtPesoDolar.Name = "txtPesoDolar";
            this.txtPesoDolar.ReadOnly = true;
            this.txtPesoDolar.Size = new System.Drawing.Size(91, 20);
            this.txtPesoDolar.TabIndex = 23;
            // 
            // txtPesoPeso
            // 
            this.txtPesoPeso.Location = new System.Drawing.Point(471, 131);
            this.txtPesoPeso.Name = "txtPesoPeso";
            this.txtPesoPeso.ReadOnly = true;
            this.txtPesoPeso.Size = new System.Drawing.Size(91, 20);
            this.txtPesoPeso.TabIndex = 24;
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.Location = new System.Drawing.Point(164, 17);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(64, 23);
            this.btnLockCotizacion.TabIndex = 25;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 184);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.txtPesoPeso);
            this.Controls.Add(this.txtPesoDolar);
            this.Controls.Add(this.txtPesoEuro);
            this.Controls.Add(this.txtDolarPeso);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroPeso);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtEuro;
    private System.Windows.Forms.TextBox txtDolar;
    private System.Windows.Forms.TextBox txtPeso;
    private System.Windows.Forms.Button btnEuro;
    private System.Windows.Forms.Button btnDolar;
    private System.Windows.Forms.Button btnPeso;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtCotizacionEuro;
    private System.Windows.Forms.TextBox txtCotizacionDolar;
    private System.Windows.Forms.TextBox txtCotizacionPeso;
    private System.Windows.Forms.TextBox txtEuroEuro;
    private System.Windows.Forms.TextBox txtEuroDolar;
    private System.Windows.Forms.TextBox txtEuroPeso;
    private System.Windows.Forms.TextBox txtDolarEuro;
    private System.Windows.Forms.TextBox txtDolarDolar;
    private System.Windows.Forms.TextBox txtDolarPeso;
    private System.Windows.Forms.TextBox txtPesoEuro;
    private System.Windows.Forms.TextBox txtPesoDolar;
    private System.Windows.Forms.TextBox txtPesoPeso;
    private System.Windows.Forms.Button btnLockCotizacion;
  }
}


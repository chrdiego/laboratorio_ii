namespace Carga
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(23, 33);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(23, 60);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(44, 13);
            this.lApellido.TabIndex = 1;
            this.lApellido.Text = "Apellido";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Location = new System.Drawing.Point(23, 87);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(26, 13);
            this.lDNI.TabIndex = 2;
            this.lDNI.Text = "DNI";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(68, 30);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 3;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(68, 57);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 4;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(68, 84);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(100, 20);
            this.textDNI.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 278);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(93, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(174, 278);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(26, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Name = "Form1";
            this.Text = "Carga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lNombre;
    private System.Windows.Forms.Label lApellido;
    private System.Windows.Forms.Label lDNI;
    private System.Windows.Forms.TextBox textNombre;
    private System.Windows.Forms.TextBox textApellido;
    private System.Windows.Forms.TextBox textDNI;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}


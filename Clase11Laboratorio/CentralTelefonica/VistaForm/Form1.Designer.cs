namespace VistaForm
{
    partial class Central
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
            this.btnLlamada = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamada
            // 
            this.btnLlamada.Location = new System.Drawing.Point(20, 13);
            this.btnLlamada.Name = "btnLlamada";
            this.btnLlamada.Size = new System.Drawing.Size(272, 40);
            this.btnLlamada.TabIndex = 0;
            this.btnLlamada.Text = "Generar Llamada";
            this.btnLlamada.UseVisualStyleBackColor = true;
            this.btnLlamada.Click += new System.EventHandler(this.BtnLlamada_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(20, 59);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(272, 40);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Facturación Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(20, 105);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(272, 40);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Facturación Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.BtnLocal_Click);
            // 
            // btnProvincial
            // 
            this.btnProvincial.Location = new System.Drawing.Point(20, 150);
            this.btnProvincial.Name = "btnProvincial";
            this.btnProvincial.Size = new System.Drawing.Size(272, 40);
            this.btnProvincial.TabIndex = 3;
            this.btnProvincial.Text = "Facturación Provincial";
            this.btnProvincial.UseVisualStyleBackColor = true;
            this.btnProvincial.Click += new System.EventHandler(this.BtnProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(20, 196);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(272, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 249);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProvincial);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnLlamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Central";
            this.Text = "Central Telefónica";
            this.Load += new System.EventHandler(this.Central_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlamada;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}


namespace Utn
{
    partial class FinalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgrAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txLegajo = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.btnEscapaProfesor = new System.Windows.Forms.Button();
            this.btnInitExam = new System.Windows.Forms.Button();
            this.btnCargarEventos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgrAlumno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txLegajo);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Location = new System.Drawing.Point(32, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // btnAgrAlumno
            // 
            this.btnAgrAlumno.Location = new System.Drawing.Point(445, 44);
            this.btnAgrAlumno.Name = "btnAgrAlumno";
            this.btnAgrAlumno.Size = new System.Drawing.Size(322, 80);
            this.btnAgrAlumno.TabIndex = 9;
            this.btnAgrAlumno.Text = "Agregar Alumno";
            this.btnAgrAlumno.UseVisualStyleBackColor = true;
            this.btnAgrAlumno.Click += new System.EventHandler(this.btnAgrAlumno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Legajo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // txLegajo
            // 
            this.txLegajo.Location = new System.Drawing.Point(190, 109);
            this.txLegajo.Name = "txLegajo";
            this.txLegajo.Size = new System.Drawing.Size(188, 26);
            this.txLegajo.TabIndex = 8;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(190, 44);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(188, 26);
            this.txNombre.TabIndex = 7;
            // 
            // btnEscapaProfesor
            // 
            this.btnEscapaProfesor.Location = new System.Drawing.Point(32, 40);
            this.btnEscapaProfesor.Name = "btnEscapaProfesor";
            this.btnEscapaProfesor.Size = new System.Drawing.Size(274, 97);
            this.btnEscapaProfesor.TabIndex = 7;
            this.btnEscapaProfesor.Text = "Se escapa el profesor";
            this.btnEscapaProfesor.UseVisualStyleBackColor = true;
            this.btnEscapaProfesor.Click += new System.EventHandler(this.btnEscapaProfesor_Click);
            // 
            // btnInitExam
            // 
            this.btnInitExam.Location = new System.Drawing.Point(349, 40);
            this.btnInitExam.Name = "btnInitExam";
            this.btnInitExam.Size = new System.Drawing.Size(196, 97);
            this.btnInitExam.TabIndex = 8;
            this.btnInitExam.Text = "Iniciar Examen";
            this.btnInitExam.UseVisualStyleBackColor = true;
            this.btnInitExam.Click += new System.EventHandler(this.BtnInitExam_Click);
            // 
            // btnCargarEventos
            // 
            this.btnCargarEventos.Location = new System.Drawing.Point(577, 40);
            this.btnCargarEventos.Name = "btnCargarEventos";
            this.btnCargarEventos.Size = new System.Drawing.Size(222, 97);
            this.btnCargarEventos.TabIndex = 9;
            this.btnCargarEventos.Text = "Cargar Eventos";
            this.btnCargarEventos.UseVisualStyleBackColor = true;
            this.btnCargarEventos.Click += new System.EventHandler(this.BtnCargarEventos_Click);
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 355);
            this.Controls.Add(this.btnCargarEventos);
            this.Controls.Add(this.btnInitExam);
            this.Controls.Add(this.btnEscapaProfesor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FinalForm";
            this.Text = "Nombre Apellido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txLegajo;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgrAlumno;
        private System.Windows.Forms.Button btnEscapaProfesor;
        private System.Windows.Forms.Button btnInitExam;
        private System.Windows.Forms.Button btnCargarEventos;
    }
}


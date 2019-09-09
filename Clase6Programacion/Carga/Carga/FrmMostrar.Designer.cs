namespace Carga
{
  partial class FrmMostrar
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
            this.lstPersona = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPersona
            // 
            this.lstPersona.FormattingEnabled = true;
            this.lstPersona.Location = new System.Drawing.Point(57, 24);
            this.lstPersona.Name = "lstPersona";
            this.lstPersona.Size = new System.Drawing.Size(120, 95);
            this.lstPersona.TabIndex = 0;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPersona);
            this.Name = "FrmMostrar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstPersona;
  }
}

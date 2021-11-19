
namespace windows_form_ui
{
    partial class frmErro
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
            this.txtBoxErroTitulo = new System.Windows.Forms.TextBox();
            this.txtBoxErroAssunto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxErroTitulo
            // 
            this.txtBoxErroTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxErroTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxErroTitulo.Location = new System.Drawing.Point(12, 12);
            this.txtBoxErroTitulo.Multiline = true;
            this.txtBoxErroTitulo.Name = "txtBoxErroTitulo";
            this.txtBoxErroTitulo.Size = new System.Drawing.Size(376, 29);
            this.txtBoxErroTitulo.TabIndex = 0;
            this.txtBoxErroTitulo.Text = "Algum erro sem tratamento foi detectado, por favor entre em contato com a adminis" +
    "tração do sistema.";
            this.txtBoxErroTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxErroAssunto
            // 
            this.txtBoxErroAssunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxErroAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxErroAssunto.Location = new System.Drawing.Point(12, 47);
            this.txtBoxErroAssunto.Multiline = true;
            this.txtBoxErroAssunto.Name = "txtBoxErroAssunto";
            this.txtBoxErroAssunto.Size = new System.Drawing.Size(376, 241);
            this.txtBoxErroAssunto.TabIndex = 1;
            // 
            // frmErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtBoxErroAssunto);
            this.Controls.Add(this.txtBoxErroTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmErro";
            this.Text = "frmErro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxErroTitulo;
        private System.Windows.Forms.TextBox txtBoxErroAssunto;
    }
}
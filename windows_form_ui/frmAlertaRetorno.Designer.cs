
namespace windows_form_ui
{
    partial class frmAlertaRetorno
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtInformacaoNecessaria = new System.Windows.Forms.TextBox();
            this.lblInformacaoNecessaria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(158, 51);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar!";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 51);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtInformacaoNecessaria
            // 
            this.txtInformacaoNecessaria.Location = new System.Drawing.Point(12, 25);
            this.txtInformacaoNecessaria.Name = "txtInformacaoNecessaria";
            this.txtInformacaoNecessaria.Size = new System.Drawing.Size(302, 20);
            this.txtInformacaoNecessaria.TabIndex = 2;
            // 
            // lblInformacaoNecessaria
            // 
            this.lblInformacaoNecessaria.AutoSize = true;
            this.lblInformacaoNecessaria.Location = new System.Drawing.Point(9, 9);
            this.lblInformacaoNecessaria.Name = "lblInformacaoNecessaria";
            this.lblInformacaoNecessaria.Size = new System.Drawing.Size(114, 13);
            this.lblInformacaoNecessaria.TabIndex = 3;
            this.lblInformacaoNecessaria.Text = "Informacao necessária";
            // 
            // frmAlertaRetorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 80);
            this.Controls.Add(this.lblInformacaoNecessaria);
            this.Controls.Add(this.txtInformacaoNecessaria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlertaRetorno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmAlertaRetorno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtInformacaoNecessaria;
        private System.Windows.Forms.Label lblInformacaoNecessaria;
    }
}
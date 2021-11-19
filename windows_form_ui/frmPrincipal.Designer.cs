
namespace windows_form_ui
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cboSelecaoTelaPrincipal = new System.Windows.Forms.ComboBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cboSelecaoTelaPrincipal
            // 
            this.cboSelecaoTelaPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelecaoTelaPrincipal.FormattingEnabled = true;
            this.cboSelecaoTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.cboSelecaoTelaPrincipal.Name = "cboSelecaoTelaPrincipal";
            this.cboSelecaoTelaPrincipal.Size = new System.Drawing.Size(400, 21);
            this.cboSelecaoTelaPrincipal.TabIndex = 0;
            this.cboSelecaoTelaPrincipal.SelectedIndexChanged += new System.EventHandler(this.cboSelecaoTela_SelectedIndexChanged);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(12, 39);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(400, 300);
            this.panelPrincipal.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 351);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.cboSelecaoTelaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelecaoTelaPrincipal;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}


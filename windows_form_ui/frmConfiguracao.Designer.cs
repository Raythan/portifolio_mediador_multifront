
namespace windows_form_ui
{
    partial class frmConfiguracao
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
            this.lblJogoDaVelhaNivel = new System.Windows.Forms.Label();
            this.grpNivelDificuldade = new System.Windows.Forms.GroupBox();
            this.lblForcaNivel = new System.Windows.Forms.Label();
            this.lblQuizNivel = new System.Windows.Forms.Label();
            this.cboJogoDaVelhaNivel = new System.Windows.Forms.ComboBox();
            this.cboForcaNivel = new System.Windows.Forms.ComboBox();
            this.cboQuizNivel = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpTipoJogo = new System.Windows.Forms.GroupBox();
            this.cboJogoDaVelhaTipoJogo = new System.Windows.Forms.ComboBox();
            this.lblJogoDaVelhaTipoJogo = new System.Windows.Forms.Label();
            this.grpNivelDificuldade.SuspendLayout();
            this.grpTipoJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJogoDaVelhaNivel
            // 
            this.lblJogoDaVelhaNivel.AutoSize = true;
            this.lblJogoDaVelhaNivel.Location = new System.Drawing.Point(6, 26);
            this.lblJogoDaVelhaNivel.Name = "lblJogoDaVelhaNivel";
            this.lblJogoDaVelhaNivel.Size = new System.Drawing.Size(75, 13);
            this.lblJogoDaVelhaNivel.TabIndex = 0;
            this.lblJogoDaVelhaNivel.Text = "Jogo da Velha";
            // 
            // grpNivelDificuldade
            // 
            this.grpNivelDificuldade.Controls.Add(this.cboQuizNivel);
            this.grpNivelDificuldade.Controls.Add(this.cboForcaNivel);
            this.grpNivelDificuldade.Controls.Add(this.cboJogoDaVelhaNivel);
            this.grpNivelDificuldade.Controls.Add(this.lblQuizNivel);
            this.grpNivelDificuldade.Controls.Add(this.lblForcaNivel);
            this.grpNivelDificuldade.Controls.Add(this.lblJogoDaVelhaNivel);
            this.grpNivelDificuldade.Location = new System.Drawing.Point(12, 12);
            this.grpNivelDificuldade.Name = "grpNivelDificuldade";
            this.grpNivelDificuldade.Size = new System.Drawing.Size(228, 116);
            this.grpNivelDificuldade.TabIndex = 2;
            this.grpNivelDificuldade.TabStop = false;
            this.grpNivelDificuldade.Text = "Nível de dificuldade";
            // 
            // lblForcaNivel
            // 
            this.lblForcaNivel.AutoSize = true;
            this.lblForcaNivel.Location = new System.Drawing.Point(47, 53);
            this.lblForcaNivel.Name = "lblForcaNivel";
            this.lblForcaNivel.Size = new System.Drawing.Size(34, 13);
            this.lblForcaNivel.TabIndex = 1;
            this.lblForcaNivel.Text = "Forca";
            // 
            // lblQuizNivel
            // 
            this.lblQuizNivel.AutoSize = true;
            this.lblQuizNivel.Location = new System.Drawing.Point(53, 82);
            this.lblQuizNivel.Name = "lblQuizNivel";
            this.lblQuizNivel.Size = new System.Drawing.Size(28, 13);
            this.lblQuizNivel.TabIndex = 2;
            this.lblQuizNivel.Text = "Quiz";
            // 
            // cboJogoDaVelhaNivel
            // 
            this.cboJogoDaVelhaNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJogoDaVelhaNivel.FormattingEnabled = true;
            this.cboJogoDaVelhaNivel.Location = new System.Drawing.Point(87, 23);
            this.cboJogoDaVelhaNivel.Name = "cboJogoDaVelhaNivel";
            this.cboJogoDaVelhaNivel.Size = new System.Drawing.Size(121, 21);
            this.cboJogoDaVelhaNivel.TabIndex = 3;
            // 
            // cboForcaNivel
            // 
            this.cboForcaNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForcaNivel.FormattingEnabled = true;
            this.cboForcaNivel.Location = new System.Drawing.Point(87, 50);
            this.cboForcaNivel.Name = "cboForcaNivel";
            this.cboForcaNivel.Size = new System.Drawing.Size(121, 21);
            this.cboForcaNivel.TabIndex = 4;
            // 
            // cboQuizNivel
            // 
            this.cboQuizNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuizNivel.FormattingEnabled = true;
            this.cboQuizNivel.Location = new System.Drawing.Point(87, 79);
            this.cboQuizNivel.Name = "cboQuizNivel";
            this.cboQuizNivel.Size = new System.Drawing.Size(121, 21);
            this.cboQuizNivel.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(165, 200);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar!";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpTipoJogo
            // 
            this.grpTipoJogo.Controls.Add(this.cboJogoDaVelhaTipoJogo);
            this.grpTipoJogo.Controls.Add(this.lblJogoDaVelhaTipoJogo);
            this.grpTipoJogo.Location = new System.Drawing.Point(12, 134);
            this.grpTipoJogo.Name = "grpTipoJogo";
            this.grpTipoJogo.Size = new System.Drawing.Size(228, 60);
            this.grpTipoJogo.TabIndex = 6;
            this.grpTipoJogo.TabStop = false;
            this.grpTipoJogo.Text = "Tipo de jogo";
            // 
            // cboJogoDaVelhaTipoJogo
            // 
            this.cboJogoDaVelhaTipoJogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJogoDaVelhaTipoJogo.FormattingEnabled = true;
            this.cboJogoDaVelhaTipoJogo.Location = new System.Drawing.Point(87, 23);
            this.cboJogoDaVelhaTipoJogo.Name = "cboJogoDaVelhaTipoJogo";
            this.cboJogoDaVelhaTipoJogo.Size = new System.Drawing.Size(121, 21);
            this.cboJogoDaVelhaTipoJogo.TabIndex = 3;
            // 
            // lblJogoDaVelhaTipoJogo
            // 
            this.lblJogoDaVelhaTipoJogo.AutoSize = true;
            this.lblJogoDaVelhaTipoJogo.Location = new System.Drawing.Point(6, 26);
            this.lblJogoDaVelhaTipoJogo.Name = "lblJogoDaVelhaTipoJogo";
            this.lblJogoDaVelhaTipoJogo.Size = new System.Drawing.Size(75, 13);
            this.lblJogoDaVelhaTipoJogo.TabIndex = 0;
            this.lblJogoDaVelhaTipoJogo.Text = "Jogo da Velha";
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.grpTipoJogo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpNivelDificuldade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracao";
            this.Text = "frmConfiguracao";
            this.grpNivelDificuldade.ResumeLayout(false);
            this.grpNivelDificuldade.PerformLayout();
            this.grpTipoJogo.ResumeLayout(false);
            this.grpTipoJogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJogoDaVelhaNivel;
        private System.Windows.Forms.GroupBox grpNivelDificuldade;
        private System.Windows.Forms.ComboBox cboQuizNivel;
        private System.Windows.Forms.ComboBox cboForcaNivel;
        private System.Windows.Forms.ComboBox cboJogoDaVelhaNivel;
        private System.Windows.Forms.Label lblQuizNivel;
        private System.Windows.Forms.Label lblForcaNivel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpTipoJogo;
        private System.Windows.Forms.ComboBox cboJogoDaVelhaTipoJogo;
        private System.Windows.Forms.Label lblJogoDaVelhaTipoJogo;
    }
}
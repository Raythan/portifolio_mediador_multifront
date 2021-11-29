
namespace windows_form_ui
{
    partial class frmJogoDaVelha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogoDaVelha));
            this.gridLetras = new System.Windows.Forms.DataGridView();
            this.COL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblJogadorDaVezText = new System.Windows.Forms.Label();
            this.lblJogadorDaVezVal = new System.Windows.Forms.Label();
            this.picBoxGpu = new System.Windows.Forms.PictureBox();
            this.btnIniciaJogo = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLimpaNomeJogador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGpu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLetras
            // 
            this.gridLetras.AllowUserToAddRows = false;
            this.gridLetras.AllowUserToDeleteRows = false;
            this.gridLetras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLetras.ColumnHeadersVisible = false;
            this.gridLetras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL1,
            this.COL2,
            this.COL3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLetras.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridLetras.Location = new System.Drawing.Point(15, 59);
            this.gridLetras.Name = "gridLetras";
            this.gridLetras.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLetras.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridLetras.RowHeadersVisible = false;
            this.gridLetras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLetras.Size = new System.Drawing.Size(303, 213);
            this.gridLetras.TabIndex = 0;
            this.gridLetras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLetras_CellClick);
            // 
            // COL1
            // 
            this.COL1.Frozen = true;
            this.COL1.HeaderText = "COL1";
            this.COL1.Name = "COL1";
            this.COL1.ReadOnly = true;
            this.COL1.Width = 5;
            // 
            // COL2
            // 
            this.COL2.Frozen = true;
            this.COL2.HeaderText = "COL2";
            this.COL2.Name = "COL2";
            this.COL2.ReadOnly = true;
            this.COL2.Width = 5;
            // 
            // COL3
            // 
            this.COL3.Frozen = true;
            this.COL3.HeaderText = "COL3";
            this.COL3.Name = "COL3";
            this.COL3.ReadOnly = true;
            this.COL3.Width = 5;
            // 
            // lblJogadorDaVezText
            // 
            this.lblJogadorDaVezText.AutoSize = true;
            this.lblJogadorDaVezText.Location = new System.Drawing.Point(12, 9);
            this.lblJogadorDaVezText.Name = "lblJogadorDaVezText";
            this.lblJogadorDaVezText.Size = new System.Drawing.Size(83, 13);
            this.lblJogadorDaVezText.TabIndex = 1;
            this.lblJogadorDaVezText.Text = "Jogador da vez:";
            // 
            // lblJogadorDaVezVal
            // 
            this.lblJogadorDaVezVal.AutoSize = true;
            this.lblJogadorDaVezVal.Location = new System.Drawing.Point(101, 9);
            this.lblJogadorDaVezVal.Name = "lblJogadorDaVezVal";
            this.lblJogadorDaVezVal.Size = new System.Drawing.Size(87, 13);
            this.lblJogadorDaVezVal.TabIndex = 2;
            this.lblJogadorDaVezVal.Text = "lblJogadorDaVez";
            // 
            // picBoxGpu
            // 
            this.picBoxGpu.Location = new System.Drawing.Point(324, 198);
            this.picBoxGpu.Name = "picBoxGpu";
            this.picBoxGpu.Size = new System.Drawing.Size(64, 64);
            this.picBoxGpu.TabIndex = 3;
            this.picBoxGpu.TabStop = false;
            // 
            // btnIniciaJogo
            // 
            this.btnIniciaJogo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIniciaJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciaJogo.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciaJogo.Image")));
            this.btnIniciaJogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciaJogo.Location = new System.Drawing.Point(324, 59);
            this.btnIniciaJogo.Name = "btnIniciaJogo";
            this.btnIniciaJogo.Size = new System.Drawing.Size(64, 57);
            this.btnIniciaJogo.TabIndex = 12;
            this.btnIniciaJogo.Text = "Resetar!";
            this.btnIniciaJogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciaJogo.UseVisualStyleBackColor = false;
            this.btnIniciaJogo.Click += new System.EventHandler(this.btnIniciaJogo_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "lblStatus";
            // 
            // btnLimpaNomeJogador
            // 
            this.btnLimpaNomeJogador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpaNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaNomeJogador.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpaNomeJogador.Image")));
            this.btnLimpaNomeJogador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpaNomeJogador.Location = new System.Drawing.Point(324, 122);
            this.btnLimpaNomeJogador.Name = "btnLimpaNomeJogador";
            this.btnLimpaNomeJogador.Size = new System.Drawing.Size(64, 70);
            this.btnLimpaNomeJogador.TabIndex = 14;
            this.btnLimpaNomeJogador.Text = "Resetar Jogador!";
            this.btnLimpaNomeJogador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpaNomeJogador.UseVisualStyleBackColor = false;
            this.btnLimpaNomeJogador.Click += new System.EventHandler(this.btnLimpaNomeJogador_Click);
            // 
            // frmJogoDaVelha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnLimpaNomeJogador);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnIniciaJogo);
            this.Controls.Add(this.picBoxGpu);
            this.Controls.Add(this.lblJogadorDaVezVal);
            this.Controls.Add(this.lblJogadorDaVezText);
            this.Controls.Add(this.gridLetras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJogoDaVelha";
            this.Text = "frmJogoDaVelha";
            ((System.ComponentModel.ISupportInitialize)(this.gridLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLetras;
        private System.Windows.Forms.Label lblJogadorDaVezText;
        private System.Windows.Forms.Label lblJogadorDaVezVal;
        private System.Windows.Forms.PictureBox picBoxGpu;
        private System.Windows.Forms.Button btnIniciaJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLimpaNomeJogador;
    }
}
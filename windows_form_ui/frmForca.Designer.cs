
namespace windows_form_ui
{
    partial class frmForca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picForca = new System.Windows.Forms.PictureBox();
            this.txtLetrasUtilizadas = new System.Windows.Forms.TextBox();
            this.txtPalavraSecreta = new System.Windows.Forms.TextBox();
            this.gridLetras = new System.Windows.Forms.DataGridView();
            this.COL1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.COL2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.COL3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.COL4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.COL5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblChances = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblChancesValor = new System.Windows.Forms.Label();
            this.lblAcertosValor = new System.Windows.Forms.Label();
            this.lblErrosValor = new System.Windows.Forms.Label();
            this.btnIniciaJogo = new System.Windows.Forms.Button();
            this.lblStatusJogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLetras)).BeginInit();
            this.SuspendLayout();
            // 
            // picForca
            // 
            this.picForca.Image = ((System.Drawing.Image)(resources.GetObject("picForca.Image")));
            this.picForca.Location = new System.Drawing.Point(12, 12);
            this.picForca.Name = "picForca";
            this.picForca.Size = new System.Drawing.Size(64, 64);
            this.picForca.TabIndex = 1;
            this.picForca.TabStop = false;
            // 
            // txtLetrasUtilizadas
            // 
            this.txtLetrasUtilizadas.BackColor = System.Drawing.SystemColors.Control;
            this.txtLetrasUtilizadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLetrasUtilizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetrasUtilizadas.Location = new System.Drawing.Point(111, 12);
            this.txtLetrasUtilizadas.Multiline = true;
            this.txtLetrasUtilizadas.Name = "txtLetrasUtilizadas";
            this.txtLetrasUtilizadas.Size = new System.Drawing.Size(277, 57);
            this.txtLetrasUtilizadas.TabIndex = 2;
            this.txtLetrasUtilizadas.Text = "A | B | C | D | E | F | G | H | I | J | K | L | M | N | O | P | Q | R | S | T | U" +
    " | V | W | X | Y | Z";
            this.txtLetrasUtilizadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPalavraSecreta
            // 
            this.txtPalavraSecreta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavraSecreta.Location = new System.Drawing.Point(12, 82);
            this.txtPalavraSecreta.Name = "txtPalavraSecreta";
            this.txtPalavraSecreta.Size = new System.Drawing.Size(376, 19);
            this.txtPalavraSecreta.TabIndex = 3;
            this.txtPalavraSecreta.Text = ":: PALAVRA SECRETA ::";
            this.txtPalavraSecreta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridLetras
            // 
            this.gridLetras.AllowUserToAddRows = false;
            this.gridLetras.AllowUserToDeleteRows = false;
            this.gridLetras.AllowUserToResizeColumns = false;
            this.gridLetras.AllowUserToResizeRows = false;
            this.gridLetras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridLetras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridLetras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLetras.ColumnHeadersVisible = false;
            this.gridLetras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL1,
            this.COL2,
            this.COL3,
            this.COL4,
            this.COL5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLetras.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridLetras.Location = new System.Drawing.Point(12, 107);
            this.gridLetras.MultiSelect = false;
            this.gridLetras.Name = "gridLetras";
            this.gridLetras.RowHeadersVisible = false;
            this.gridLetras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLetras.Size = new System.Drawing.Size(188, 181);
            this.gridLetras.TabIndex = 4;
            this.gridLetras.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLetras_CellMouseUp);
            // 
            // COL1
            // 
            this.COL1.HeaderText = "COL1";
            this.COL1.Name = "COL1";
            this.COL1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COL1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COL1.Width = 5;
            // 
            // COL2
            // 
            this.COL2.HeaderText = "COL2";
            this.COL2.Name = "COL2";
            this.COL2.Width = 5;
            // 
            // COL3
            // 
            this.COL3.HeaderText = "COL3";
            this.COL3.Name = "COL3";
            this.COL3.Width = 5;
            // 
            // COL4
            // 
            this.COL4.HeaderText = "COL4";
            this.COL4.Name = "COL4";
            this.COL4.Width = 5;
            // 
            // COL5
            // 
            this.COL5.HeaderText = "COL5";
            this.COL5.Name = "COL5";
            this.COL5.Width = 5;
            // 
            // lblChances
            // 
            this.lblChances.AutoSize = true;
            this.lblChances.Location = new System.Drawing.Point(206, 107);
            this.lblChances.Name = "lblChances";
            this.lblChances.Size = new System.Drawing.Size(52, 13);
            this.lblChances.TabIndex = 5;
            this.lblChances.Text = "Chances:";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Location = new System.Drawing.Point(206, 153);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(34, 13);
            this.lblErros.TabIndex = 6;
            this.lblErros.Text = "Erros:";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Location = new System.Drawing.Point(206, 131);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(46, 13);
            this.lblAcertos.TabIndex = 7;
            this.lblAcertos.Text = "Acertos:";
            // 
            // lblChancesValor
            // 
            this.lblChancesValor.AutoSize = true;
            this.lblChancesValor.Location = new System.Drawing.Point(264, 107);
            this.lblChancesValor.Name = "lblChancesValor";
            this.lblChancesValor.Size = new System.Drawing.Size(13, 13);
            this.lblChancesValor.TabIndex = 8;
            this.lblChancesValor.Text = "0";
            // 
            // lblAcertosValor
            // 
            this.lblAcertosValor.AutoSize = true;
            this.lblAcertosValor.Location = new System.Drawing.Point(264, 131);
            this.lblAcertosValor.Name = "lblAcertosValor";
            this.lblAcertosValor.Size = new System.Drawing.Size(13, 13);
            this.lblAcertosValor.TabIndex = 9;
            this.lblAcertosValor.Text = "0";
            // 
            // lblErrosValor
            // 
            this.lblErrosValor.AutoSize = true;
            this.lblErrosValor.Location = new System.Drawing.Point(264, 153);
            this.lblErrosValor.Name = "lblErrosValor";
            this.lblErrosValor.Size = new System.Drawing.Size(13, 13);
            this.lblErrosValor.TabIndex = 10;
            this.lblErrosValor.Text = "0";
            // 
            // btnIniciaJogo
            // 
            this.btnIniciaJogo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIniciaJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciaJogo.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciaJogo.Image")));
            this.btnIniciaJogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciaJogo.Location = new System.Drawing.Point(235, 229);
            this.btnIniciaJogo.Name = "btnIniciaJogo";
            this.btnIniciaJogo.Size = new System.Drawing.Size(153, 59);
            this.btnIniciaJogo.TabIndex = 11;
            this.btnIniciaJogo.Text = "Resetar! (Nova palavra)";
            this.btnIniciaJogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciaJogo.UseVisualStyleBackColor = false;
            this.btnIniciaJogo.Click += new System.EventHandler(this.btnIniciaJogo_Click);
            // 
            // lblStatusJogo
            // 
            this.lblStatusJogo.AutoSize = true;
            this.lblStatusJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusJogo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStatusJogo.Location = new System.Drawing.Point(206, 181);
            this.lblStatusJogo.Name = "lblStatusJogo";
            this.lblStatusJogo.Size = new System.Drawing.Size(74, 13);
            this.lblStatusJogo.TabIndex = 12;
            this.lblStatusJogo.Text = "Status Jogo";
            // 
            // frmForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblStatusJogo);
            this.Controls.Add(this.btnIniciaJogo);
            this.Controls.Add(this.lblErrosValor);
            this.Controls.Add(this.lblAcertosValor);
            this.Controls.Add(this.lblChancesValor);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblChances);
            this.Controls.Add(this.gridLetras);
            this.Controls.Add(this.txtPalavraSecreta);
            this.Controls.Add(this.txtLetrasUtilizadas);
            this.Controls.Add(this.picForca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForca";
            this.Text = "frmForca";
            ((System.ComponentModel.ISupportInitialize)(this.picForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLetras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picForca;
        private System.Windows.Forms.TextBox txtLetrasUtilizadas;
        private System.Windows.Forms.TextBox txtPalavraSecreta;
        private System.Windows.Forms.DataGridView gridLetras;
        private System.Windows.Forms.DataGridViewButtonColumn COL1;
        private System.Windows.Forms.DataGridViewButtonColumn COL2;
        private System.Windows.Forms.DataGridViewButtonColumn COL3;
        private System.Windows.Forms.DataGridViewButtonColumn COL4;
        private System.Windows.Forms.DataGridViewButtonColumn COL5;
        private System.Windows.Forms.Label lblChances;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblChancesValor;
        private System.Windows.Forms.Label lblAcertosValor;
        private System.Windows.Forms.Label lblErrosValor;
        private System.Windows.Forms.Button btnIniciaJogo;
        private System.Windows.Forms.Label lblStatusJogo;
    }
}
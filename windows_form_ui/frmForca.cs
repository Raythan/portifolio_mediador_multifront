using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_ui
{
    public partial class frmForca : Form
    {
        string palavraSecreta = string.Empty;
        List<string> letrasUtilizadas = new List<string>();
        int chances, acertos, erros = 0;
        public frmForca()
        {
            InitializeComponent();
            IniciaJogo();
        }

        private void CarregarPalavraSecreta()
        {
            txtPalavraSecreta.Text = "";
            for (int i = 0; i < palavraSecreta.Length; i++)
                txtPalavraSecreta.Text += "*";
        }
        private void LimpaLetrasUtilizadas()
        {
            letrasUtilizadas = new List<string>();
            txtLetrasUtilizadas.Text = string.Empty;
            lblStatusJogo.Text = "Configuração carregada.";
        }
        private void CarregarLetrasGrid()
        {
            if (gridLetras.Rows.Count > 0)
                for(int i = 0; i < gridLetras.Rows.Count;)
                    gridLetras.Rows.RemoveAt(0);

            gridLetras.Rows.Add("A", "B", "C", "D", "E");
            gridLetras.Rows.Add("F", "G", "H", "I", "J");
            gridLetras.Rows.Add("K", "L", "M", "N", "O");
            gridLetras.Rows.Add("P", "Q", "R", "S", "T");
            gridLetras.Rows.Add("U", "V", "W", "X", "Y");
            gridLetras.Rows.Add("Z");
            gridLetras.BackgroundColor = SystemColors.Control;
            lblStatusJogo.Text = "Configuração carregada.";
        }
        private void AtualizaLetrasUtilizadas(string letra)
        {
            if (!VerificaLetraJaPressionada(letra))
            {
                letrasUtilizadas.Add(letra);
                StringBuilder letras = new StringBuilder();

                letrasUtilizadas.ForEach(f =>
                {
                    if (letrasUtilizadas.Count == 1)
                        letras.Append(f);
                    else
                        letras.Append($"{f} | ");
                });

                letras.Length = letras.Length >= 3 ? letras.Length - 3 : letras.Length;
                txtLetrasUtilizadas.Text = letras.ToString();
            }
            else
                lblStatusJogo.Text = "Você já pressionou essa letra!";
                //MessageBox.Show("Você já pressionou essa letra!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void gridLetras_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            string letraSelecionada = Convert.ToString(gridLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            
            if (!string.IsNullOrEmpty(letraSelecionada))
            {
                if (!AnalisaJogadas())
                    return;

                lblStatusJogo.Text = $"Apertou letra {letraSelecionada}.";
                if (palavraSecreta.Contains(letraSelecionada))
                {
                    AtualizaContagem(true, letraSelecionada);
                    StringBuilder palavraNova = new StringBuilder();
                    var palavraSecretaArray = palavraSecreta.ToArray();
                    var txtPalavraSecretaArray = txtPalavraSecreta.Text.ToArray();

                    for (int i = 0; i < palavraSecretaArray.Count(); i++)
                        palavraNova.Append(palavraSecretaArray[i].ToString().Equals(letraSelecionada) ? $"{letraSelecionada}" : $"{txtPalavraSecretaArray[i]}");

                    gridLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Green;
                    gridLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                    txtPalavraSecreta.Text = palavraNova.ToString();
                }
                else
                {
                    AtualizaContagem(false, letraSelecionada);
                    gridLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Red;
                    gridLetras.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                }
                AtualizaLetrasUtilizadas(letraSelecionada);
            }
        }
        private void AtualizaContagem(bool valor, string letra)
        {
            if (!VerificaLetraJaPressionada(letra))
            {
                chances--;
                acertos = valor ? acertos + 1 : acertos;
                erros = !valor ? erros + 1 : erros;
                lblChancesValor.Text = Convert.ToString(chances);
                lblAcertosValor.Text = Convert.ToString(acertos);
                lblErrosValor.Text = Convert.ToString(erros);
                lblStatusJogo.Text = valor ? $"Acertou a letra {letra}." : $"Letra {letra} incorreta.";
            }
        }
        private void IniciaContagem() 
        {
            chances = palavraSecreta.Length;
            acertos = erros = 0;
            lblChancesValor.Text = Convert.ToString(chances);
            lblAcertosValor.Text = Convert.ToString(acertos);
            lblErrosValor.Text = Convert.ToString(erros);
            lblStatusJogo.Text = "Contagem iniciada!";
        }
        private void IniciaJogo()
        {
            NovaPalavra();
            CarregarLetrasGrid();
            CarregarPalavraSecreta();
            IniciaContagem();
            LimpaLetrasUtilizadas();
            lblStatusJogo.Text = "Jogo iniciado!";
        }
        private bool AnalisaJogadas()
        {
            if (chances <= 0)
            {
                lblStatusJogo.Text = "Fim de jogo, você perdeu!";
                //MessageBox.Show("Fim de jogo, você perdeu!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (!txtPalavraSecreta.Text.Contains('*'))
            {
                lblStatusJogo.Text = "Fim de jogo, você ganhou!";
                //MessageBox.Show("Fim de jogo, você ganhou!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return true;
        }
        private void NovaPalavra() => palavraSecreta = "ESPIRIGUIDIBERTO";
        private bool VerificaLetraJaPressionada(string letra) => letrasUtilizadas.Contains(letra);
        private void btnIniciaJogo_Click(object sender, EventArgs e) => IniciaJogo();
    }
}

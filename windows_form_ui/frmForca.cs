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
        List<string> palavrasPermitidas;
        int chances, acertos, erros = 0;
        int[] chancesArray = { 26, 15, 7};
        public frmForca()
        {   
            InitializeComponent();
            IniciaJogo();
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
            acertos = erros = 0;
            lblChancesValor.Text = Convert.ToString(chances);
            lblAcertosValor.Text = Convert.ToString(acertos);
            lblErrosValor.Text = Convert.ToString(erros);
            lblStatusJogo.Text = "Contagem iniciada!";
        }
        private void IniciaJogo()
        {
            CarregarConfiguracao();
            CarregaPalavrasPermitidasOnlineOffline();
            NovaPalavra();
            CarregarLetrasGrid();
            IniciaContagem();
            LimpaLetrasUtilizadas();
            lblStatusJogo.Text = "Jogo iniciado!";
        }
        private void CarregarConfiguracao()
        {
            Configuracao configuracao = Extender.LerArquivoEmAssembly<Configuracao>(new Configuracao().jsonFile);
            chances = chancesArray[configuracao.niveisUtilizados["Forca"]];
        }
        private void CarregaPalavrasPermitidasOnlineOffline()
        {
            try
            {
                lblStatusJogo.Text = "Procurando palavra...";
                palavrasPermitidas = Request.Get("https://raw.githubusercontent.com/Raythan/portifolio_mediador_multifront/main/windows_form_ui/palavras_forca.txt", "github")
                    .Split(',').ToList();
            }
            catch
            {
                palavrasPermitidas = Extender.LerArquivoEmAssembly("palavras_forca.txt", ',');
            }
        }
        private bool AnalisaJogadas()
        {
            if (chances <= 0)
            {
                lblStatusJogo.Text = $"Fim de jogo, você perdeu!\r\nPalavra correta {palavraSecreta}";
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
        private void AnalisaAcaoDoJogador(int rowIndex, int colIndex)
        {
            string letraSelecionada = Convert.ToString(gridLetras.Rows[rowIndex].Cells[colIndex].Value);
            Color color = Color.Red;

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

                    color = Color.Green;
                    txtPalavraSecreta.Text = palavraNova.ToString();
                }
                else
                    AtualizaContagem(false, letraSelecionada);

                gridLetras.Rows[rowIndex].Cells[colIndex].Style.SelectionBackColor = color;
                gridLetras.Rows[rowIndex].Cells[colIndex].Style.BackColor = color;
                AtualizaLetrasUtilizadas(letraSelecionada);
            }
        }
        private void NovaPalavra()
        {
            Random rd = new Random();
            palavraSecreta = palavrasPermitidas[rd.Next(0, palavrasPermitidas.Count())];

            txtPalavraSecreta.Text = "";
            for (int i = 0; i < palavraSecreta.Length; i++)
                txtPalavraSecreta.Text += "*";
        }
        private void gridLetras_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) => AnalisaAcaoDoJogador(e.RowIndex, e.ColumnIndex);
        private void frmForca_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < gridLetras.Rows.Count; i++)
                for (int j = 0; j < gridLetras.Columns.Count; j++)
                    if (Convert.ToString(gridLetras.Rows[i].Cells[j].Value).Equals(Convert.ToString(e.KeyCode)))
                        AnalisaAcaoDoJogador(i, j);
        }
        private bool VerificaLetraJaPressionada(string letra) => letrasUtilizadas.Contains(letra);
        private void btnIniciaJogo_Click(object sender, EventArgs e) => IniciaJogo();
    }
}

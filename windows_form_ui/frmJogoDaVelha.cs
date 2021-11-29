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
    public partial class frmJogoDaVelha : Form
    {
        private List<MarcacaoJogador> marcacaoJogadorList = new List<MarcacaoJogador>()
        {
            new MarcacaoJogador { id = 0, marcador = "X", nomeJogador = "", cor = Color.Red },
            new MarcacaoJogador { id = 1, marcador = "O", nomeJogador = "", cor = Color.Blue },

        };
        private int jogadorDaVez = 0;
        private bool permiteJogada, vencedor = true;
        private string nomeDaCpu = "Competidor";
        Configuracao configuracao;
        public frmJogoDaVelha(bool carregado)
        {
            InitializeComponent();
            if(carregado)
                IniciaJogo();
        }

        private void IniciaJogo()
        {
            CarregarConfiguracao();
            IniciaNomeDosJogadores();
            SalvarConfiguracao();
            CarregarLetrasGrid();
            IniciaValores();
        }

        private void IniciaNomeDosJogadores()
        {
            marcacaoJogadorList[0].nomeJogador = configuracao.ultimoJogadorUmJogoDaVelha;
            marcacaoJogadorList[1].nomeJogador = configuracao.ultimoJogadorDoisJogoDaVelha;

            if (string.IsNullOrEmpty(marcacaoJogadorList[0].nomeJogador)){
                while (string.IsNullOrEmpty(marcacaoJogadorList[0].nomeJogador))
                {
                    var formDialog = new frmAlertaRetorno("Alerta", "Informe o nome do jogador ou você não poderá jogar", marcacaoJogadorList[0].nomeJogador);
                    formDialog.ShowDialog();
                    marcacaoJogadorList[0].nomeJogador = formDialog.txtBoxValor;
                    configuracao.ultimoJogadorUmJogoDaVelha = formDialog.txtBoxValor;
                }
            }
            
            if (configuracao.tiposUtilizados["Jogo da Velha"] == 1)
            {
                while (string.IsNullOrEmpty(marcacaoJogadorList[1].nomeJogador) || marcacaoJogadorList[1].nomeJogador.Equals(nomeDaCpu))
                {
                    var formDialog = new frmAlertaRetorno("Alerta", "Informe o nome do segundo jogador ou você não poderá jogar", marcacaoJogadorList[1].nomeJogador);
                    formDialog.ShowDialog();
                    marcacaoJogadorList[1].nomeJogador = formDialog.txtBoxValor;
                    configuracao.ultimoJogadorDoisJogoDaVelha = formDialog.txtBoxValor;
                }
            }
            else
            {
                marcacaoJogadorList[1].nomeJogador = nomeDaCpu;
                configuracao.ultimoJogadorDoisJogoDaVelha = nomeDaCpu;
            }

            atualizaLabelNomeJogador();
        }

        private void IniciaValores()
        {
            jogadorDaVez = 0;
            permiteJogada = true;
            lblStatus.Text = "Jogo Iniciado!";
            vencedor = false;
            atualizaLabelNomeJogador();
        }

        private void CarregarConfiguracao()
        {
            configuracao = Extender.LerArquivoEmAssembly<Configuracao>(new Configuracao().jsonFile);
            marcacaoJogadorList[0].nomeJogador = !string.IsNullOrEmpty(configuracao.ultimoJogadorUmJogoDaVelha) ? configuracao.ultimoJogadorUmJogoDaVelha : string.Empty;
            marcacaoJogadorList[1].nomeJogador = !string.IsNullOrEmpty(configuracao.ultimoJogadorDoisJogoDaVelha) ? configuracao.ultimoJogadorDoisJogoDaVelha : string.Empty;
        }

        private void SalvarConfiguracao() => Extender.EscreveObjetoAssembly(new Configuracao().jsonFile, configuracao);

        private void CarregarLetrasGrid()
        {
            if (gridLetras.Rows.Count > 0)
                for (int i = 0; i < gridLetras.Rows.Count;)
                    gridLetras.Rows.RemoveAt(0);

            gridLetras.Columns[0].Width = (int)(gridLetras.Width * 0.3);
            gridLetras.Columns[1].Width = (int)(gridLetras.Width * 0.3);
            gridLetras.Columns[2].Width = (int)(gridLetras.Width * 0.3);
            gridLetras.Rows.Add(" ", " ", " ");
            gridLetras.Rows.Add(" ", " ", " ");
            gridLetras.Rows.Add(" ", " ", " ");
            gridLetras.BackgroundColor = SystemColors.Control;
            gridLetras.Rows[0].Height = (int)(gridLetras.Height * 0.3);
            gridLetras.Rows[1].Height = (int)(gridLetras.Height * 0.3);
            gridLetras.Rows[2].Height = (int)(gridLetras.Height * 0.3);
        }

        private void AnalisaAcaoDoJogador(int rowIndex, int colIndex)
        {
            string celula = Convert.ToString(gridLetras.Rows[rowIndex].Cells[colIndex].Value);
            AnalisaPreenchimentoGrid();
            if (!vencedor)
            {
                MarcacaoJogador marcacao = marcacaoJogadorList.Where(w => w.id == jogadorDaVez).FirstOrDefault();
                if (string.IsNullOrEmpty(celula) || string.IsNullOrWhiteSpace(celula))
                {
                    gridLetras.Rows[rowIndex].Cells[colIndex].Style.SelectionBackColor = marcacao.cor;
                    gridLetras.Rows[rowIndex].Cells[colIndex].Style.BackColor = marcacao.cor;
                    gridLetras.Rows[rowIndex].Cells[colIndex].Value = marcacao.marcador;
                    AnalisaJogada();
                    jogadorDaVez = jogadorDaVez == 0 ? 1 : 0;
                    atualizaLabelNomeJogador();
                }
                else
                    lblStatus.Text = "Esse campo já foi utilizado, escolha outro.";
            }
            else
            {
                string vencedorNome = nomeDoJogadorVencedor();
                string vencedorLabel = vencedor ? $", Vencedor: {vencedorNome}" : "empatado";
                lblStatus.Text = $"O jogo terminou {vencedorLabel}";
            }
        }

        private void AnalisaPreenchimentoGrid()
        {
            permiteJogada = false;
            for(int i = 0; i < gridLetras.Rows.Count && !permiteJogada; i++)
                for (int j = 0; j < gridLetras.Rows[i].Cells.Count && !permiteJogada; j++)
                    if (string.IsNullOrWhiteSpace(Convert.ToString(gridLetras.Rows[i].Cells[j].Value)))
                        permiteJogada = true;
        }

        private void AnalisaJogada()
        {
            var list = new List<dynamic>()
            {
                new { colx = 0, coly = 1, colz = 2, rowx = 0, rowy = 0, rowz = 0},
                new { colx = 0, coly = 1, colz = 2, rowx = 1, rowy = 1, rowz = 1},
                new { colx = 0, coly = 1, colz = 2, rowx = 2, rowy = 2, rowz = 2},
                new { colx = 0, coly = 0, colz = 0, rowx = 0, rowy = 1, rowz = 2},
                new { colx = 1, coly = 1, colz = 1, rowx = 0, rowy = 1, rowz = 2},
                new { colx = 2, coly = 2, colz = 2, rowx = 0, rowy = 1, rowz = 2},
                new { colx = 0, coly = 1, colz = 2, rowx = 0, rowy = 1, rowz = 2},
                new { colx = 2, coly = 1, colz = 0, rowx = 0, rowy = 1, rowz = 2},
            };

            foreach (var item in list)
            {
                string celula1 = gridLetras.Rows[item.rowx].Cells[item.colx].Value;
                string celula2 = gridLetras.Rows[item.rowy].Cells[item.coly].Value;
                string celula3 = gridLetras.Rows[item.rowz].Cells[item.colz].Value;
                if (celula1.Equals(celula2) && celula2.Equals(celula3)
                    && !string.IsNullOrWhiteSpace(celula1)
                    && !string.IsNullOrWhiteSpace(celula2)
                    && !string.IsNullOrWhiteSpace(celula3))
                {
                    permiteJogada = false;
                    vencedor = true;
                }
            }
                
        }

        private void gridLetras_CellClick(object sender, DataGridViewCellEventArgs e) => AnalisaAcaoDoJogador(e.RowIndex, e.ColumnIndex);

        private void btnLimpaNomeJogador_Click(object sender, EventArgs e)
        {
            configuracao.ultimoJogadorUmJogoDaVelha = string.Empty;
            configuracao.ultimoJogadorDoisJogoDaVelha = string.Empty;
            SalvarConfiguracao();
            IniciaJogo();
        }

        private void btnIniciaJogo_Click(object sender, EventArgs e) => IniciaJogo();
        private void atualizaLabelNomeJogador() => lblJogadorDaVezVal.Text = marcacaoJogadorList.Where(w => w.id == jogadorDaVez).Select(s => s.nomeJogador).FirstOrDefault();
        private string nomeDoJogadorVencedor() => marcacaoJogadorList.Where(w => w.id != jogadorDaVez).Select(s => s.nomeJogador).FirstOrDefault();
    }
}

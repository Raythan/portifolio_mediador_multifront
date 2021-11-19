using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace windows_form_ui
{
    public partial class frmConfiguracao : Form
    {
        private Dictionary<string, int> niveis = new Dictionary<string, int>
        {
            { "Facil", 0},
            { "Medio", 1},
            { "Dificil", 2}
        };

        private Dictionary<string, int> tipos = new Dictionary<string, int>
        {
            { "Individual", 0},
            { "Dupla", 1}
        };

        public Configuracao configuracao;
        public frmConfiguracao(Configuracao configuracao)
        {
            this.configuracao = configuracao;
            InitializeComponent();
            CarregarConfiguracoes();
        }

        private void CarregarConfiguracoes()
        {
            cboForcaNivel.DataSource = new BindingSource(niveis, null);
            cboForcaNivel.DisplayMember = "Key";
            cboForcaNivel.ValueMember = "Value";
            cboForcaNivel.SelectedIndex = 0;

            cboJogoDaVelhaNivel.DataSource = new BindingSource(niveis, null);
            cboJogoDaVelhaNivel.DisplayMember = "Key";
            cboJogoDaVelhaNivel.ValueMember = "Value";
            cboJogoDaVelhaNivel.SelectedIndex = 0;

            cboQuizNivel.DataSource = new BindingSource(niveis, null);
            cboQuizNivel.DisplayMember = "Key";
            cboQuizNivel.ValueMember = "Value";
            cboQuizNivel.SelectedIndex = 0;

            cboJogoDaVelhaTipoJogo.DataSource = new BindingSource(tipos, null);
            cboJogoDaVelhaTipoJogo.DisplayMember = "Key";
            cboJogoDaVelhaTipoJogo.ValueMember = "Value";
            cboJogoDaVelhaTipoJogo.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e) => SalvarConfiguracoes();

        private void SalvarConfiguracoes()
        {
            Dictionary<string, int> niveisInterno = new Dictionary<string, int>
            {
                { "Jogo da Velha", (int)cboJogoDaVelhaNivel.SelectedValue },
                { "Quiz", (int)cboQuizNivel.SelectedValue },
                { "Forca", (int)cboForcaNivel.SelectedValue }
            };
            Dictionary<string, int> tiposInterno = new Dictionary<string, int>
            {
                { "Jogo da Velha", (int)cboJogoDaVelhaTipoJogo.SelectedValue }
            };
            configuracao = new Configuracao(niveisInterno, tiposInterno);
        }
    }
}

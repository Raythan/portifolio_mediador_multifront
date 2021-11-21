using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace windows_form_ui
{
    public partial class frmConfiguracao : Form
    {
        public Configuracao configuracao = new Configuracao();
        public frmConfiguracao()
        {
            InitializeComponent();
            CarregarArquivoConfiguracao();
            CarregarConfiguracoes();
            lblStatus.Text = "";
        }
        private void CarregarArquivoConfiguracao()
        {
            if (Extender.ExisteArquivo(configuracao.jsonFile))
                CarregarConfiguracoes();
            else
            {
                Extender.CriaArquivo(configuracao.jsonFile);
                Extender.EscreveObjetoAssembly(configuracao.jsonFile, configuracao);
                CarregarArquivoConfiguracao();
            }
        }
        private void CarregarConfiguracoes()
        {
            configuracao = Extender.LerArquivoEmAssembly<Configuracao>(configuracao.jsonFile);
            PopularComboBoxDicionario(cboJogoDaVelhaNivel, configuracao.niveisDominio, configuracao.niveisUtilizados, configuracao.jogos[0]);
            PopularComboBoxDicionario(cboQuizNivel, configuracao.niveisDominio, configuracao.niveisUtilizados, configuracao.jogos[1]);
            PopularComboBoxDicionario(cboForcaNivel, configuracao.niveisDominio, configuracao.niveisUtilizados, configuracao.jogos[2]);
            PopularComboBoxDicionario(cboJogoDaVelhaTipoJogo, configuracao.tiposDominio, configuracao.tiposUtilizados, configuracao.jogos[0]);
        }
        private void PopularComboBoxDicionario(ComboBox combo, object bindingSource, Dictionary<string, int> dicionario, string key, int indice = 0)
        {
            combo.DataSource = new BindingSource(bindingSource, null);
            combo.DisplayMember = "Key";
            combo.ValueMember = "Value";
            dicionario.TryGetValue(key, out indice);
            combo.SelectedIndex = indice;
        }
        private void SalvarConfiguracoes()
        {
            configuracao.niveisUtilizados = new Dictionary<string, int>
            {
                { "Jogo da Velha", (int)cboJogoDaVelhaNivel.SelectedValue },
                { "Quiz", (int)cboQuizNivel.SelectedValue },
                { "Forca", (int)cboForcaNivel.SelectedValue }
            };
            configuracao.tiposUtilizados = new Dictionary<string, int>
            {
                { "Jogo da Velha", (int)cboJogoDaVelhaTipoJogo.SelectedValue }
            };

            Extender.EscreveObjetoAssembly(configuracao.jsonFile, configuracao);
            lblStatus.Text = "Configuração salva!";
        }
        private void btnSalvar_Click(object sender, EventArgs e) => SalvarConfiguracoes();
    }
}

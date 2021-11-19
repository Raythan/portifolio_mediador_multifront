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
    public partial class frmPrincipal : Form
    {
        private string titulo = "Jogos";
        private Form form;
        private Configuracao configuracao = new Configuracao(new Dictionary<string, int>(), new Dictionary<string, int>());
        private Dictionary<string, int> telas;

        private Dictionary<int, Form> formularios;

        public frmPrincipal()
        {
            InitializeComponent();
            CarregarTelasDeSelecao();
            CarregarFormularios();
            Text = titulo;
        }

        private void CarregarFormularios()
        {
            formularios = new Dictionary<int, Form>
            {
                { 0, new frmConfiguracao(configuracao)},
                { 1, new frmConfiguracao(configuracao)},
                { 2, new frmConfiguracao(configuracao)},
                { 3, new frmConfiguracao(configuracao)}
            };
        }

        private void CarregarTelasDeSelecao()
        {
            telas = new Dictionary<string, int>
            {
                { "Configuração", 0},
                { "Jogo da Velha", 1},
                { "Forca", 2},
                { "Quiz", 3}
            };
            if (telas.Count() != formularios.Count())
            {
                MessageBox.Show("Quantidade de menus cadastrados diferente da quantidade de formularios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(); 
            }
            
            cboSelecaoTelaPrincipal.DataSource = new BindingSource(telas, null);
            cboSelecaoTelaPrincipal.DisplayMember = "Key";
            cboSelecaoTelaPrincipal.ValueMember = "Value";
        }

        private void cboSelecaoTela_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (panelPrincipal.Controls.Count > 0)
                    panelPrincipal.Controls.RemoveAt(0);

                formularios.TryGetValue((int)cboSelecaoTelaPrincipal.SelectedValue, out form);
                form.TopLevel = false;
                form.AutoScroll = true;
                panelPrincipal.Controls.Add(form);
                form.Show();
                Text = $"{titulo} - {cboSelecaoTelaPrincipal.SelectedText}";
            }
            catch (Exception ex)
            {
                // Inserir formulário de erro
            }
        }
    }
}

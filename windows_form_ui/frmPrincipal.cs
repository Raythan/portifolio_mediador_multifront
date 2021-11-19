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
        private int formInicial = 2;

        public frmPrincipal()
        {
            InitializeComponent();
            CarregarDicionarios();
            CarregarTelasDeSelecao();
            Text = titulo;
        }

        private void CarregarDicionarios()
        {
            formularios = new Dictionary<int, Form>
            {
                { 0, new frmConfiguracao(configuracao)},
                { 1, new frmJogoDaVelha()},
                { 2, new frmForca()},
                { 3, new frmQuiz()}
            };

            telas = new Dictionary<string, int>
            {
                { "Configuração", 0},
                { "Jogo da Velha", 1},
                { "Forca", 2},
                { "Quiz", 3}
            };
        }

        private void CarregarTelasDeSelecao()
        {
            if (telas.Count() != formularios.Count())
            {
                MessageBox.Show("Quantidade de menus cadastrados diferente da quantidade de formularios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception();
            }

            cboSelecaoTelaPrincipal.DataSource = new BindingSource(telas, null);
            cboSelecaoTelaPrincipal.DisplayMember = "Key";
            cboSelecaoTelaPrincipal.ValueMember = "Value";
            cboSelecaoTelaPrincipal.SelectedValue = formInicial;
        }

        private void cboSelecaoTela_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (panelPrincipal.Controls.Count > 0)
                    panelPrincipal.Controls.RemoveAt(0);

                try
                {
                    formularios.TryGetValue((int)cboSelecaoTelaPrincipal.SelectedValue, out form);
                }
                catch
                {
                    formularios.TryGetValue(formInicial, out form);
                }
                
                form.TopLevel = false;
                form.AutoScroll = true;
                panelPrincipal.Controls.Add(form);
                form.Show();
                Text = $"{titulo} - {cboSelecaoTelaPrincipal.Text}";
            }
            catch (Exception ex)
            {
                form = new frmErro(ex)
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                panelPrincipal.Controls.Add(form);
                form.Show();
                Text = $"{titulo} - Erro";
            }
        }
    }
}

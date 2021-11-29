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
    public partial class frmAlertaRetorno : Form
    {
        public string txtBoxValor;
        public frmAlertaRetorno(string nomeDialog, string labelAlerta, string ultimoJogador = null)
        {
            InitializeComponent();
            Text = nomeDialog;
            lblInformacaoNecessaria.Text = labelAlerta;
            txtInformacaoNecessaria.Text = ultimoJogador;
            CenterToScreen();
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtBoxValor = txtInformacaoNecessaria.Text;
            Close();
        }
    }
}

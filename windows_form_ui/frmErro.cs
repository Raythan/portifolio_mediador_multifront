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
    public partial class frmErro : Form
    {
        public frmErro(Exception ex)
        {
            InitializeComponent();
            CarregarInformacaoException(ex);
        }

        private void CarregarInformacaoException(Exception ex)
        {
            string innerMsgEx = ex.InnerException != null ? $"Inner {ex.InnerException.Message}\r\n" : string.Empty;
            string msgEx = $"Ex: {ex.Message}\r\n{innerMsgEx}Stack: {ex.StackTrace}";
            txtBoxErroAssunto.Text = msgEx;
        }
    }
}

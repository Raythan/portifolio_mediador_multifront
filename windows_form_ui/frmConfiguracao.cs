using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
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

        //private async void roda()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        //Create a new bitmap.
        //        using (var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
        //                                       Screen.PrimaryScreen.Bounds.Height,
        //                                       PixelFormat.Format24bppRgb))
        //        {
        //            // Create a graphics object from the bitmap.
        //            using (var gfxScreenshot = Graphics.FromImage(bmpScreenshot))
        //            {
        //                // Take the screenshot from the upper left corner to the right bottom corner.
        //                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
        //                                            Screen.PrimaryScreen.Bounds.Y,
        //                                            0,
        //                                            0,
        //                                            Screen.PrimaryScreen.Bounds.Size,
        //                                            CopyPixelOperation.SourceCopy);

        //                // Save the screenshot to the specified path that the user has chosen.
        //                bmpScreenshot.Save(@"C:\GitHub\portifolio_mediador_multifront\windows_form_ui\bin\Debug\teste2.png", ImageFormat.Png);
        //            };
        //        };

        //        using (Bitmap sourceImage = Extender.LerBitmapAssembly(textBox1.Text))
        //        {
        //            using (Bitmap template = Extender.LerBitmapAssembly(textBox2.Text))
        //            {
        //                ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.921f);

        //                TemplateMatch[] matchings = tm.ProcessImage(sourceImage, template);
        //                if (matchings.Length > 0)
        //                {
        //                    label1.Invoke((MethodInvoker)delegate {
        //                        label1.Text = "Estou vendo.";
        //                    });
        //                }   
        //                else
        //                {
        //                    label1.Invoke((MethodInvoker)delegate {
        //                        label1.Text = "Não estou vendo.";
        //                    });
        //                }
        //            }
        //        };
        //        Thread.Sleep(100);
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Task.Run(() => roda());
        //}
    }
}

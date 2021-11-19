using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form_ui
{
    public class Configuracao
    {
        public Dictionary<string, int> niveis;
        public Dictionary<string, int> tipos;

        public Configuracao(Dictionary<string, int> niveis, Dictionary<string, int> tipos)
        {
            this.niveis = niveis;
            this.tipos = tipos;
        }
    }
}

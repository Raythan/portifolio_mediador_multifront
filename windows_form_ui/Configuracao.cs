using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form_ui
{
    public class Configuracao
    {
        public string jsonFile = "configuracao.txt";
        public List<string> jogos
        {
            get
            {
                return jogosStatic;
            }
        }
        private static List<string> jogosStatic = new List<string>()
        {
            "Jogo da Velha",
            "Quiz",
            "Forca"
        };
        public Dictionary<string, int> niveisDominio
        {
            get
            {
                return new Dictionary<string, int>
                {
                    { "Facil", 0},
                    { "Medio", 1},
                    { "Dificil", 2}
                };
            }
        }
        public Dictionary<string, int> tiposDominio
        {
            get
            {
                return new Dictionary<string, int>
                {
                    { "Individual", 0},
                    { "Dupla", 1}
                };
            }
        }
        public Dictionary<string, int> niveisUtilizados { get; set; } = new Dictionary<string, int>
        {
            { jogosStatic[0], 0 },
            { jogosStatic[1], 0 },
            { jogosStatic[2], 0 }
        };
        public Dictionary<string, int> tiposUtilizados { get; set; } = new Dictionary<string, int>
        {
            { jogosStatic[0], 0 }
        };
    }
}

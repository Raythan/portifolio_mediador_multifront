using Newtonsoft.Json;
using System.Collections.Generic;

namespace windows_form_ui
{
    public class Configuracao
    {
        [JsonIgnore]
        public string jsonFile = "configuracao.txt";
        [JsonIgnore]
        public List<string> jogos = new List<string>()
        {
            "Jogo da Velha",
            "Quiz",
            "Forca"
        };
        [JsonIgnore]
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

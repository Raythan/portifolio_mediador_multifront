using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace windows_form_ui
{
    public static class Extender
    {
        public static Assembly Assembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }
        public static string AssemblyDirectory
        {
            get
            {
                return Path.GetDirectoryName(Assembly.Location);
            }
        }
        public static string LerArquivoEmAssembly(string nomeArquivo)
        {
            return File.ReadAllText($"{AssemblyDirectory}\\{nomeArquivo}");
        }
        public static List<string> LerArquivoEmAssembly(string nomeArquivo, char separador)
        {
            return File.ReadAllText($"{AssemblyDirectory}\\{nomeArquivo}").Split(separador).ToList();
        }
        public static T LerArquivoEmAssembly<T>(string nomeArquivo) => JsonConvert.DeserializeObject<T>(File.ReadAllText($"{AssemblyDirectory}\\{nomeArquivo}"));
        public static bool ExisteArquivo(string nomeArquivo) => File.Exists($"{AssemblyDirectory}\\{nomeArquivo}");
        public static void CriaArquivo(string nomeArquivo) => File.Create($"{AssemblyDirectory}\\{nomeArquivo}").Dispose();
        public static void EscreveObjetoAssembly(string nomeArquivo, object objeto) => File.WriteAllText($"{AssemblyDirectory}\\{nomeArquivo}", JsonConvert.SerializeObject(objeto));
        public static Image LerImagemAssembly(string nomeArquivo) => Image.FromFile($"{AssemblyDirectory}\\{nomeArquivo}");
        public static Bitmap LerBitmapAssembly(string nomeArquivo) => (Bitmap)Bitmap.FromFile($"{AssemblyDirectory}\\{nomeArquivo}");
    }
}

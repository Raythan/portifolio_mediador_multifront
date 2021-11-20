using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
    }
}

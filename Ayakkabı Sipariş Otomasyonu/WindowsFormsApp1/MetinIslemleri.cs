using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MetinIslemleri
    {
        private static DirectoryInfo proje_konum()
        {
            String ProjectFolder = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\";
            DirectoryInfo dir = new DirectoryInfo(ProjectFolder);
            return dir;
        }

        public static StreamReader sr(string text_yolu)
        {
            StreamReader oku = new StreamReader(proje_konum().FullName + text_yolu);
            return oku;
        }

        public static FileStream fs(string txt_yolu)
        {
            FileStream file = new FileStream(proje_konum().FullName + txt_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            return file;
        }

        public static StreamWriter sw(string txt_yolu, FileStream fs)
        {
            StreamWriter writer;
            if (fs == null)
                writer = File.AppendText(proje_konum() + txt_yolu);
            else
                writer = new StreamWriter(fs);

            return writer;
        }
    }
}
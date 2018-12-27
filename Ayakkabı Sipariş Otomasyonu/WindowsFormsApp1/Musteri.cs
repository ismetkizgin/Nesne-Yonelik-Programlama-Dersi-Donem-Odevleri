using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Musteri
    {
        private static string Isim;
        public string isim
        {
            get
            {
                return Isim;
            }

            set
            {
                Isim = value;
                Isim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Isim);
            }
        }
        private static string Adres;
        private static string Telefon;
        private static string Musteri_Kodu;
        private static string Rutbe;
        public string adres { get { return Adres; } set { Adres = value; } }
        public string telefon { get { return Telefon; } set { Telefon = value; } }
        public string musteri_kodu { get { return Musteri_Kodu; } set { Musteri_Kodu = value; } }
        public string rutbe { get { return Rutbe; } set { Rutbe = value; } }

        private string kullainici_kodu_olustur()
        {
            StreamReader oku = MetinIslemleri.sr(@"belgeler//giris.txt");

            string satir = oku.ReadLine();
            string son_kullanici_kodu = "0", siparis_kodu;
            int i = 0;
            while (satir != null)
            {
                if (i % 4 == 3)
                {
                    son_kullanici_kodu = satir;
                    satir = oku.ReadLine();
                }
                else
                    satir = oku.ReadLine();
                i++;
            }
            oku.Close();
            siparis_kodu = (Convert.ToInt32(son_kullanici_kodu) + 1).ToString();
            return siparis_kodu;
        }

        public void kullanici_ekle(string kullanici_adi, string sifre, string rutbe)
        {
            string kullanici_kodu = kullainici_kodu_olustur();
            StreamWriter sw = MetinIslemleri.sw(@"belgeler//giris.txt", null);
            sw.WriteLine(kullanici_adi);
            sw.WriteLine(sifre);
            sw.WriteLine(rutbe);
            sw.WriteLine(kullanici_kodu);
            sw.Close();
        }
    }
}

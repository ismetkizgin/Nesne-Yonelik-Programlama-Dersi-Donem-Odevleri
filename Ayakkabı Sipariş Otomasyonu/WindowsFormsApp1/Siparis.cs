
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Siparis
    {
        private static bool siparis_onay;
        public bool siparisonay { get { return siparis_onay; } set { siparis_onay = value; } }
        private string siparis_tutari
        {
            get
            {
                Odeme odeme = new Odeme();
                switch(odeme.odemetürü)
                {
                    case 0:
                        return odeme.tutar.ToString();
                        break;
                    case 1:
                        Cek cek = new Cek();
                        return cek.tutar.ToString();
                        break;
                    default:
                        KrediKarti kart = new KrediKarti();
                        return kart.tutar.ToString();
                        break;
                }
            }
        }
        public struct SiparisBilgi
        {
            public string siparis_kodu;
            public string musteri_kodu;
            public string tarih;
            public string toplam_tutar;
            public string adsoyad;
            public string telefon;
            public string adres;
        }

        private Musteri Musteri;
        public Musteri musteri
        {
            get
            {
                if (Musteri == null)
                    Musteri = new Musteri();
                return Musteri;
            }
        }


        private SiparisDetay Siparisdetay;
        public SiparisDetay siparisdetay
        {
            get
            {
                if (Siparisdetay == null)
                    Siparisdetay = new SiparisDetay();
                return Siparisdetay;
            }
        }

        public SiparisBilgi[] siparisbilgi = new SiparisBilgi[0];

        public Siparis()
        {
            StreamReader oku = MetinIslemleri.sr(@"belgeler//siparis.txt");

            string satir = oku.ReadLine();
            string[] bilgi = new string[0];
            while (satir != null)
            {
                if (bilgi.Length < 7)
                {
                    Array.Resize(ref bilgi, bilgi.Length + 1);
                    bilgi[bilgi.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
                else
                {
                    if (bilgi[1] == musteri.musteri_kodu || musteri.rutbe == "1")
                    {
                        Array.Resize(ref siparisbilgi, siparisbilgi.Length + 1);
                        siparisbilgi[siparisbilgi.Length - 1].siparis_kodu = bilgi[0];
                        siparisbilgi[siparisbilgi.Length - 1].musteri_kodu = bilgi[1];
                        siparisbilgi[siparisbilgi.Length - 1].tarih = bilgi[2];
                        siparisbilgi[siparisbilgi.Length - 1].toplam_tutar = bilgi[3];
                        siparisbilgi[siparisbilgi.Length - 1].adsoyad = bilgi[4];
                        siparisbilgi[siparisbilgi.Length - 1].telefon = bilgi[5];
                        siparisbilgi[siparisbilgi.Length - 1].adres = bilgi[6];
                    }
                        Array.Resize(ref bilgi, 1);
                        bilgi[bilgi.Length - 1] = satir;
                        satir = oku.ReadLine();
                }
            }

            oku.Close();

            if (bilgi.Length > 0)
            {
                if (bilgi[1] == musteri.musteri_kodu || musteri.rutbe == "1")
                {
                    Array.Resize(ref siparisbilgi, siparisbilgi.Length + 1);
                    siparisbilgi[siparisbilgi.Length - 1].siparis_kodu = bilgi[0];
                    siparisbilgi[siparisbilgi.Length - 1].musteri_kodu = bilgi[1];
                    siparisbilgi[siparisbilgi.Length - 1].tarih = bilgi[2];
                    siparisbilgi[siparisbilgi.Length - 1].toplam_tutar = bilgi[3];
                    siparisbilgi[siparisbilgi.Length - 1].adsoyad = bilgi[4];
                    siparisbilgi[siparisbilgi.Length - 1].telefon = bilgi[5];
                    siparisbilgi[siparisbilgi.Length - 1].adres = bilgi[6];
                }
            }
        }

        private string siparis_kodu_olustur()
        {
            StreamReader oku = MetinIslemleri.sr(@"belgeler//siparis.txt");

            string satir = oku.ReadLine();
            string son_siparis_kodu = "0", siparis_kodu;
            int i = 0;
            while (satir != null)
            {
                if (i % 6 == 0 )
                {
                    son_siparis_kodu = satir;
                    satir = oku.ReadLine();
                }
                i++;
                satir = oku.ReadLine();
            }
            oku.Close();
            siparis_kodu = (Convert.ToInt32(son_siparis_kodu) + 1).ToString();

            return siparis_kodu;
        }

        public void siparis_ver(ListView lst)
        {
            string siparis_kodu = siparis_kodu_olustur();
            StreamWriter sw = MetinIslemleri.sw(@"belgeler\\siparis.txt",null);
            sw.WriteLine(siparis_kodu);
            sw.WriteLine(musteri.musteri_kodu);
            sw.WriteLine(DateTime.Now);
            sw.WriteLine(this.siparis_tutari);
            sw.WriteLine(musteri.isim);
            sw.WriteLine(musteri.telefon);
            sw.WriteLine(musteri.adres);
            sw.Close();

            siparisdetay.detay_kayit(siparis_kodu, lst);
        }
    }
}
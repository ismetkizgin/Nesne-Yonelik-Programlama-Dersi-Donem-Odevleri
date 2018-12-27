using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class SiparisDetay
    {
        private Siparis sipariS;
        private Siparis siparis
        {
            get
            {
                if (sipariS == null)
                    sipariS = new Siparis();
                return sipariS;
            }
        }

        private Cek ceK;
        private Cek cek
        {
            get
            {
                if (ceK == null)
                    ceK = new Cek();
                return ceK;
            }
        }

        private KrediKarti Kredi;
        private KrediKarti kredi
        {
            get
            {
                if (Kredi == null)
                    Kredi = new KrediKarti();
                return Kredi;
            }
        }

        private Nakit nakiT;
        private Nakit nakit
        {
            get
            {
                if (nakiT == null)
                    nakiT = new Nakit();
                return nakiT;
            }
        }

        private Odeme odemE;
        private Odeme odeme
        {
            get
            {
                if (odemE == null)
                    odemE = new Odeme();
                return odemE;
            }
        }

        public struct SipariOdemeBilgi
        {
            public string sipari_kodu;
            public string odeme_turu;
            public string kredi_numarasi;
            public string tarih;
            public string taksit;
            public string banka_adi;
            public string cek_sahibi;
        }

        public struct SiparisBilgi
        {
            public string siparis_kodu;
            public string urunadi;
            public string fiyat;
            public string agirlik;
            public string adet;
        }

        public SiparisBilgi[] siparisbilgi = new SiparisBilgi[0];
        public SipariOdemeBilgi[] sipariodemebilgi = new SipariOdemeBilgi[0];

        public SiparisDetay()
        {
            StreamReader oku = MetinIslemleri.sr(@"belgeler//siparisdetay.txt");

            string satir = oku.ReadLine();
            string[] bilgi = new string[0];
            int i = 0;
            while (satir != null)
            {
                if (bilgi.Length < 5)
                {
                    Array.Resize(ref bilgi, bilgi.Length + 1);
                    bilgi[bilgi.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
                else
                {
                    Array.Resize(ref siparisbilgi, siparisbilgi.Length + 1);
                    siparisbilgi[siparisbilgi.Length - 1].siparis_kodu = bilgi[0];
                    siparisbilgi[siparisbilgi.Length - 1].urunadi = bilgi[1];
                    siparisbilgi[siparisbilgi.Length - 1].fiyat = bilgi[2];
                    siparisbilgi[siparisbilgi.Length - 1].agirlik = bilgi[3];
                    siparisbilgi[siparisbilgi.Length - 1].adet = bilgi[4];

                    Array.Resize(ref bilgi, 1);
                    bilgi[bilgi.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
            }
            oku.Close();
            if (bilgi.Length == 5)
            {
                Array.Resize(ref siparisbilgi, siparisbilgi.Length + 1);
                siparisbilgi[siparisbilgi.Length - 1].siparis_kodu = bilgi[0];
                siparisbilgi[siparisbilgi.Length - 1].urunadi = bilgi[1];
                siparisbilgi[siparisbilgi.Length - 1].fiyat = bilgi[2];
                siparisbilgi[siparisbilgi.Length - 1].agirlik = bilgi[3];
                siparisbilgi[siparisbilgi.Length - 1].adet = bilgi[4];
            }

            oku = MetinIslemleri.sr(@"belgeler//odeme.txt");
            satir = oku.ReadLine();
            Array.Resize(ref bilgi, 0);

            while (satir != null)
            {
                if (satir != ";")
                {
                    Array.Resize(ref bilgi, bilgi.Length + 1);
                    bilgi[bilgi.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
                else
                {
                    Array.Resize(ref sipariodemebilgi, sipariodemebilgi.Length + 1);
                    sipariodemebilgi[sipariodemebilgi.Length - 1].sipari_kodu = bilgi[0];
                    sipariodemebilgi[sipariodemebilgi.Length - 1].odeme_turu = bilgi[1];

                    switch (bilgi[1])
                    {
                        case "1":
                            sipariodemebilgi[sipariodemebilgi.Length - 1].cek_sahibi = bilgi[2];
                            sipariodemebilgi[sipariodemebilgi.Length - 1].banka_adi = bilgi[3];
                            break;
                        case "2":
                            sipariodemebilgi[sipariodemebilgi.Length - 1].kredi_numarasi = bilgi[2];
                            sipariodemebilgi[sipariodemebilgi.Length - 1].tarih = bilgi[3];
                            sipariodemebilgi[sipariodemebilgi.Length - 1].taksit = bilgi[4];
                            break;
                    }
                    Array.Resize(ref bilgi, 0);
                    satir = oku.ReadLine();
                }
            }
            oku.Close();
        }

        public void detay_kayit(string siparis_kodu, ListView lst)
        {
            StreamWriter sw = MetinIslemleri.sw(@"belgeler//siparisdetay.txt",null);
            for (int i = 0; i < lst.Items.Count; i++)
            {
                sw.WriteLine(siparis_kodu);
                sw.WriteLine(lst.Items[i].SubItems[0].Text);
                sw.WriteLine(lst.Items[i].SubItems[1].Text);
                sw.WriteLine(lst.Items[i].SubItems[2].Text);
                sw.WriteLine(lst.Items[i].SubItems[3].Text);
            }
            sw.Close();

            StreamWriter sw1 = MetinIslemleri.sw(@"belgeler\\odeme.txt", null);
            sw1.WriteLine(siparis_kodu);
            sw1.WriteLine(odeme.odemetürü);
            switch (odeme.odemetürü)
            {
                case 1:
                    sw1.WriteLine(cek.ceksahibi);
                    sw1.WriteLine(cek.banka);
                    break;
                case 2:
                    sw1.WriteLine(kredi.hesapno);
                    sw1.WriteLine(kredi.sk_tarihi);
                    sw1.Write(kredi.taksit);
                    break;
            }
            sw1.WriteLine(";");
            sw1.Close();
        }
    }
}
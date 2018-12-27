using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SiparisOnayFormu : Form
    {
        Musteri musteri = new Musteri();
        Cek cek = new Cek();
        Nakit nakit = new Nakit();
        KrediKarti kart = new KrediKarti();
        Odeme odeme = new Odeme();
        Siparis siparis = new Siparis();
        public SiparisOnayFormu()
        {
            InitializeComponent();
        }

        private void SiparisOnayFormu_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = musteri.isim;
            lblTelefon.Text = musteri.telefon;
            lblAdres.Text = musteri.adres;
            switch(odeme.odemetürü)
            {
                case 0:
                    lblOdeme.Text = "Nakit";
                    lblTutar.Text = nakit.tutar.ToString();
                    groupBox1.Visible = false;
                    break;
                case 1:
                    lblOdeme.Text = "Çek";
                    lblKartANDCekSahibi.Text = cek.ceksahibi;
                    lblSKTarihANDBankaAdi.Text = cek.banka;
                    lblTutar.Text = cek.tutar.ToString();
                    lblTaksit.Visible = lbl_taksit_belirtec.Visible = false;
                    lblKartANDCek_belirtec.Text = "Çek Sahibi";
                    lblSKTarihANDBanka_belirtec.Text = "Banka Adı";
                    groupBox1.Text = "Çek Bilgileri";
                    break;
                default:
                    lblOdeme.Text = "Kredi Kartı";
                    lblSKTarihANDBankaAdi.Text = kart.sk_tarihi.ToString();
                    lblKartANDCekSahibi.Text = kart.hesapno;
                    lblTaksit.Text = kart.taksit;
                    lblTutar.Text = kart.tutar.ToString();
                    groupBox1.Text = "Kart Bilgileri";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            siparis.siparisonay = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siparis.siparisonay = true;
            this.Close();
        }
    }
}

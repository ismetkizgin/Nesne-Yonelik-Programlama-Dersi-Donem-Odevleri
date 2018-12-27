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
    public partial class SiparisListesiForm : Form
    {
        Siparis siparislistesi = new Siparis();
        SiparisDetay siparidetay = new SiparisDetay();
        public SiparisListesiForm()
        {
            InitializeComponent();
        }

        private void SiparisListesi_Load(object sender, EventArgs e)
        {
            string[] bilgi = new string[6];
            for (int i = 0; i < siparislistesi.siparisbilgi.Length; i++)
            {
                bilgi[0] = siparislistesi.siparisbilgi[i].siparis_kodu;
                bilgi[1] = siparislistesi.siparisbilgi[i].adsoyad;
                bilgi[2] = siparislistesi.siparisbilgi[i].telefon;
                bilgi[3] = siparislistesi.siparisbilgi[i].adres;
                bilgi[4] = siparislistesi.siparisbilgi[i].toplam_tutar;
                bilgi[5] = siparislistesi.siparisbilgi[i].tarih;

                lstVwSiparisListesi.Items.Add(new ListViewItem(bilgi));
            }
        }

        private void lbl(bool vsl)
        {
            lblKartANDCekSahibi.Visible = lblSKTarihANDBankaAdi.Visible = lblTaksit.Visible = vsl;
        }

        private void lstVwSiparisListesi_Click(object sender, EventArgs e)
        {
            if (lstVwSiparisListesi.SelectedIndices.Count > 0)
            {
                lstVwSiparisDetay.Items.Clear();
                string[] bilgi = new string[5];
                for (int i = 0; i < siparidetay.siparisbilgi.Length; i++)
                {
                    if (siparidetay.siparisbilgi[i].siparis_kodu == lstVwSiparisListesi.SelectedItems[0].SubItems[0].Text)
                    {
                        bilgi[0] = siparidetay.siparisbilgi[i].urunadi;
                        bilgi[1] = siparidetay.siparisbilgi[i].agirlik;
                        bilgi[2] = siparidetay.siparisbilgi[i].adet;
                        bilgi[3] = siparidetay.siparisbilgi[i].fiyat;
                        bilgi[4] = Convert.ToString(Convert.ToDouble(bilgi[3]) * Convert.ToDouble(bilgi[2]));

                        lstVwSiparisDetay.Items.Add(new ListViewItem(bilgi));
                    }
                }

                for (int i = 0; i < siparidetay.sipariodemebilgi.Length; i++)
                {
                    if (siparidetay.sipariodemebilgi[i].sipari_kodu == lstVwSiparisListesi.SelectedItems[0].SubItems[0].Text)
                    {
                        lblOdeme.Visible = true;
                        switch (siparidetay.sipariodemebilgi[i].odeme_turu)
                        {
                            case "0":
                                lbl(false);
                                lblOdeme.Text = "Ödeme Türü: ";
                                lblOdeme.Text +="Nakit";
                                break;
                            case "1":
                                lbl(true);
                                lblTaksit.Visible = false;
                                lblOdeme.Text = "Ödeme Türü: ";
                                lblKartANDCekSahibi.Text = "Çek Sahibi: ";
                                lblSKTarihANDBankaAdi.Text = "Banka Adı: ";
                                lblOdeme.Text += " Cek";
                                lblKartANDCekSahibi.Text += siparidetay.sipariodemebilgi[i].cek_sahibi;
                                lblSKTarihANDBankaAdi.Text += siparidetay.sipariodemebilgi[i].banka_adi;
                                break;
                            case "2":
                                lbl(true);
                                lblOdeme.Text = "Ödeme Türü: ";
                                lblKartANDCekSahibi.Text = "Kart Numarası: ";
                                lblSKTarihANDBankaAdi.Text = "S.K Tarihi: ";
                                lblTaksit.Text = "Takst: ";
                                lblOdeme.Text += " Kredi Kartı";
                                lblKartANDCekSahibi.Text += siparidetay.sipariodemebilgi[i].kredi_numarasi;
                                lblSKTarihANDBankaAdi.Text += siparidetay.sipariodemebilgi[i].tarih;
                                lblTaksit.Text += siparidetay.sipariodemebilgi[i].taksit;
                                break;
                        }
                    }
                }
            }
        }

        private void SiparisListesiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PanelForm frm = new PanelForm();
            frm.Show();
        }
    }
}
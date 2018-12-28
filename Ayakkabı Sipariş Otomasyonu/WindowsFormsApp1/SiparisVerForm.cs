using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SiparisVerForm : Form
    {
        Musteri musteri_bilgi = new Musteri();
        Siparis siparis = new Siparis();
        Nakit nakit = new Nakit();
        KrediKarti kart = new KrediKarti();
        Cek cek = new Cek();
        public SiparisVerForm()
        {
            InitializeComponent();
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
            drpTaksit.SelectedIndex = 0;
            StreamReader oku = MetinIslemleri.sr(@"belgeler\\urun.txt");
            string[] bilgi = new string[0];

            string satir = oku.ReadLine();
            while (satir != null)
            {
                if (bilgi.Length != 3)
                {
                    Array.Resize(ref bilgi, bilgi.Length + 1);
                    bilgi[bilgi.Length - 1] = satir;
                    satir = oku.ReadLine();

                }
                else
                {
                    lstVwUrunBilgisi.Items.Add(new ListViewItem(bilgi));
                    Array.Resize(ref bilgi, 1);
                    bilgi[bilgi.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
            }
            lstVwUrunBilgisi.Items.Add(new ListViewItem(bilgi));
            oku.Close();
        }

        private void lstVwUrunBilgisi_DoubleClick(object sender, EventArgs e)
        {
            if (lstVwUrunBilgisi.SelectedIndices.Count > 0)
            {
                string[] bilgi = new string[4];
                bool arama = false;
                int indis=0;
                bilgi[0] = lstVwUrunBilgisi.SelectedItems[0].SubItems[0].Text;
                bilgi[1] = lstVwUrunBilgisi.SelectedItems[0].SubItems[1].Text;
                bilgi[2] = lstVwUrunBilgisi.SelectedItems[0].SubItems[2].Text;
                bilgi[3] = "1";

                for (int i = 0; i <lstVwSiparisListesi.Items.Count; i++)
                {
                    if (lstVwSiparisListesi.Items[i].SubItems[0].Text == bilgi[0])
                    {
                        arama = true;
                        indis = i;
                    }
                }
                if(arama)
                {
                    int adet = Convert.ToInt32(lstVwSiparisListesi.Items[indis].SubItems[3].Text);
                    lstVwSiparisListesi.Items[indis].SubItems[3].Text = (adet + 1).ToString();
                }
                else
                    lstVwSiparisListesi.Items.Add(new ListViewItem(bilgi));
            }
            else
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Seçim Hatası");
        }

        private void btnSprTemizle_Click(object sender, EventArgs e)
        {
            lstVwSiparisListesi.Items.Clear();
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (lstVwSiparisListesi.SelectedIndices.Count > 0)
            {
                int adet = Convert.ToInt32(lstVwSiparisListesi.SelectedItems[0].SubItems[3].Text);
                if (adet > 1)
                    lstVwSiparisListesi.SelectedItems[0].SubItems[3].Text = (adet - 1).ToString();
            }
            else
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Seçim Hatası");
        }

        private void btnArtir_Click(object sender, EventArgs e)
        {
            if (lstVwSiparisListesi.SelectedIndices.Count > 0)
            {
                int adet = Convert.ToInt32(lstVwSiparisListesi.SelectedItems[0].SubItems[3].Text);
                lstVwSiparisListesi.SelectedItems[0].SubItems[3].Text = (adet + 1).ToString();
            }
            else
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Seçim Hatası");
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (lstVwSiparisListesi.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Ürünü listeden çıkarmak istediğinizden emin misiniz ?", "Ürün Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstVwSiparisListesi.Items.RemoveAt(lstVwSiparisListesi.SelectedItems[0].Index);
                }
            }
            else
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Seçim Hatası");
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text != string.Empty && txtAdSoyad.Text != string.Empty && txtTel.Text != string.Empty)
            {
                if (rdnBtnCek.Checked == true && (txtKardNumarasıANDCekSahibi.Text == string.Empty || txtBankaAdi.Text == string.Empty))
                    MessageBox.Show("Lütfen tüm bilgileri doldurduğunuzdan emin olunuz!!! ", "Bilgi Girişi Hatası");
                else if (rdnBtnKartNumarasi.Checked == true && (txtKardNumarasıANDCekSahibi.Text == string.Empty || drpTaksit.Text == string.Empty))
                    MessageBox.Show("Lütfen tüm bilgileri doldurduğunuzdan emin olunuz!!! ", "Bilgi Girişi Hatası");
                else
                {
                    if (lstVwSiparisListesi.Items.Count > 0)
                    {
                        decimal toplam_tutar = 0;
                        for (int i = 0; i < lstVwSiparisListesi.Items.Count; i++)
                        {
                            toplam_tutar += Convert.ToDecimal(lstVwSiparisListesi.Items[i].SubItems[1].Text) * Convert.ToDecimal(lstVwSiparisListesi.Items[i].SubItems[3].Text);
                        }

                        siparis.musteri.isim = txtAdSoyad.Text;
                        siparis.musteri.telefon = txtTel.Text;
                        siparis.musteri.adres = txtAdres.Text;
                        

                        if (rdnBtnNakit.Checked == true)
                        {
                            nakit.odemetürü = 0;
                            nakit.n_veren_kisi = txtAdSoyad.Text;
                            nakit.tutar = toplam_tutar;
                        }
                        else if (rdnBtnKartNumarasi.Checked == true)
                        {
                            kart.odemetürü = 2;
                            kart.hesapno = txtKardNumarasıANDCekSahibi.Text;
                            kart.sk_tarihi = Convert.ToDateTime(String.Format("{0}/{1}/{2}","1",drpAy.Text,drpYil.Text));
                            kart.taksit = drpTaksit.Text;
                            kart.tutar = toplam_tutar;
                        }
                        else
                        {
                            cek.ceksahibi = txtKardNumarasıANDCekSahibi.Text;
                            cek.banka = txtBankaAdi.Text;
                            cek.odemetürü = 1;
                            cek.tutar = toplam_tutar;
                        }

                        SiparisOnayFormu frm = new SiparisOnayFormu();
                        frm.ShowDialog();

                        if (siparis.siparisonay)
                        {
                            if (rdnBtnCek.Checked == true && cek.yetki != true)
                                MessageBox.Show("1000 TL altında satışlara çek ile ödeme yapılmamaktadır !!!", "Ödeme Hatası");
                            else if (rdnBtnKartNumarasi.Checked == true && kart.yetki != true)
                                MessageBox.Show("Kartınızın son kullanma tarihini kontrol ediniz !!!", "Ödeme Hatası");
                            else
                            {
                                siparis.siparis_ver(lstVwSiparisListesi);
                                txtAdres.Text = txtAdSoyad.Text = txtTel.Text = txtBankaAdi.Text = txtKardNumarasıANDCekSahibi.Text = string.Empty;
                                drpTaksit.SelectedIndex = 0;
                                lstVwSiparisListesi.Items.Clear();
                                MessageBox.Show("Siparişiniz başarılı bir şekilde gerçekleştirilmişir. ","Sipariş İşlem");
                            }
                        }
                    }
                    else
                        MessageBox.Show("Sipariş Listesi Boş Sipariş Veremezsiniz!!!", "Bilgi Girişi Hatası");
                }
            }
            else
                MessageBox.Show("Lütfen tüm bilgileri doldurduğunuzdan emin olunuz!!! ", "Bilgi Girişi Hatası");
        }

        private void rdn(bool vsb)
        {
            txtKardNumarasıANDCekSahibi.Visible = drpYil.Visible = drpAy.Visible = drpTaksit.Visible = vsb;
            lblKardNumarasıANDCekSahibi.Visible = lblSKTarihANDBankaAdi.Visible = lblTaksit.Visible = vsb;
        }

        private void rdnBtnNakit_CheckedChanged(object sender, EventArgs e)
        {
            rdn(false);
            txtBankaAdi.Visible = false;
        }

        private void rdnBtnCek_CheckedChanged(object sender, EventArgs e)
        {
            rdn(false);
            txtKardNumarasıANDCekSahibi.Visible = txtBankaAdi.Visible = lblSKTarihANDBankaAdi.Visible = lblKardNumarasıANDCekSahibi.Visible = true;
            lblSKTarihANDBankaAdi.Text = "Banka Adi";
            lblKardNumarasıANDCekSahibi.Text = "Çek Sahibi";
            lblKardNumarasıANDCekSahibi.Location = new Point(242,32);
        }

        private void rdnBtnKartNumarasi_CheckedChanged(object sender, EventArgs e)
        {
            rdn(true);
            txtBankaAdi.Visible = false;
            lblSKTarihANDBankaAdi.Text = "S.K. Tarihi";
            lblKardNumarasıANDCekSahibi.Text = "Kredi Kartı Numarası";
            lblKardNumarasıANDCekSahibi.Location = new Point(198,32);
        }

        private void KullaniciIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            PanelForm frm = new PanelForm();
            frm.Show();
        }
    }
}
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
    public partial class UrunIslemleriForm : Form
    {
        public UrunIslemleriForm()
        {
            InitializeComponent();
        }

        private void txt_guncelle()
        {
            FileStream fs = MetinIslemleri.fs(@"belgeler\\urun.txt");
            StreamWriter sw = MetinIslemleri.sw(null,fs);
            
            for (int i = 0; i < lstVwUrunBilgisi.Items.Count; i++)
            {
                sw.WriteLine(lstVwUrunBilgisi.Items[i].SubItems[0].Text);
                sw.WriteLine(lstVwUrunBilgisi.Items[i].SubItems[1].Text);
                sw.WriteLine(lstVwUrunBilgisi.Items[i].SubItems[2].Text);
            }

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnGrpUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtEUrunTuru.Text != string.Empty && txtEUrunFiyat.Text != string.Empty && txtEUrunAgirlik.Text != string.Empty)
            {
                string[] bilgi = { txtEUrunTuru.Text, txtEUrunFiyat.Text, txtEUrunAgirlik.Text };
                lstVwUrunBilgisi.Items.Add(new ListViewItem(bilgi));

                StreamWriter sw = MetinIslemleri.sw(@"belgeler\\urun.txt", null);
                sw.WriteLine();
                sw.WriteLine(txtEUrunTuru.Text);
                sw.WriteLine(txtEUrunFiyat.Text);
                sw.Write(txtEUrunAgirlik.Text);
                sw.Close();

                txtEUrunFiyat.Text = txtEUrunTuru.Text = txtEUrunAgirlik.Text = string.Empty;
            }
            else
                MessageBox.Show("Lütfen tüm bilgileri doldurduğunuzdan emin olunuz!!! ","Bilgi Girişi Hatası");
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void UrunIslem_FormClosed(object sender, FormClosedEventArgs e)
        {
            PanelForm frm = new PanelForm();
            frm.Show();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (lstVwUrunBilgisi.SelectedIndices.Count > 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox2.Location = new Point(12,12);

                txtGUrunTuru.Text = lstVwUrunBilgisi.SelectedItems[0].SubItems[0].Text;
                txtGUrunFiyat.Text = lstVwUrunBilgisi.SelectedItems[0].SubItems[1].Text;
                txtGUrunAgirlik.Text = lstVwUrunBilgisi.SelectedItems[0].SubItems[2].Text;
            }
            else
                MessageBox.Show("Lütfen bir ürün seçiniz!","Seçim Hatası");
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (lstVwUrunBilgisi.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Ürünü silmek istediğinizden emin misiniz ?","Ürün Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstVwUrunBilgisi.Items.RemoveAt(lstVwUrunBilgisi.SelectedItems[0].Index);
                    txt_guncelle();
                }
            }
            else
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Seçim Hatası");
        }

        private void btnGrpUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGUrunTuru.Text != string.Empty && txtGUrunFiyat.Text != string.Empty && txtGUrunAgirlik.Text != string.Empty)
            {
                if (MessageBox.Show("Ürünü bilgilerini güncellemek istediğinizden emin misiniz ?", "Ürün Güncelleme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstVwUrunBilgisi.SelectedItems[0].SubItems[0].Text = txtGUrunTuru.Text;
                    lstVwUrunBilgisi.SelectedItems[0].SubItems[1].Text = txtGUrunFiyat.Text;
                    lstVwUrunBilgisi.SelectedItems[0].SubItems[2].Text = txtGUrunAgirlik.Text;
                    txt_guncelle();
                    groupBox2.Visible = false;
                }
            }
            else
                MessageBox.Show("Lütfen tüm bilgileri doldurduğunuzdan emin olunuz!!! ","Bilgi Girişi Hatası");
        }

        private void UrunIslem_Load(object sender, EventArgs e)
        {
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

        private void btnSiparisDurumu_Click(object sender, EventArgs e)
        {

        }
    }
}

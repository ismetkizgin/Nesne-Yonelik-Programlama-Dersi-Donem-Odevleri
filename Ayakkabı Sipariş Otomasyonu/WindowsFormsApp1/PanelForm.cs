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
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }

        private void PanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            UyeOlForm frm = new UyeOlForm("1");
            frm.ShowDialog();
        }

        private void PanelForm_Load(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            if (musteri.rutbe == "0")
            {
                btnYoneticiEkle.Visible = false;
                btnUrunIslemleri.Visible = false;
                this.Size = new Size(238, 142);
            }
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            SiparisVerForm frm = new SiparisVerForm();
            frm.Show();
            this.Hide();
        }

        private void btnSiparisListesi_Click(object sender, EventArgs e)
        {
            SiparisListesiForm frm = new SiparisListesiForm();
            frm.Show();
            this.Hide();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            UrunIslemleriForm frm = new UrunIslemleriForm();
            frm.Show();
            this.Hide();
        }
    }
}

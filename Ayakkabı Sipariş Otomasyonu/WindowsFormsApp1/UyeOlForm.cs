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
    public partial class UyeOlForm : Form
    {
        Musteri musteri = new Musteri();
        private string rutbe;
        public UyeOlForm(string rutbe)
        {
            InitializeComponent();
            this.rutbe = rutbe;
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                musteri.kullanici_ekle(txtKullaniciAdi.Text, txtSifre.Text, rutbe);
                MessageBox.Show("Üyelik işleminiz gerçekliştirilmiştir keyifli alışverişler dileriz", "Üye Ol");
                this.Close();
            }
            else
                MessageBox.Show("Şifreleri uyumlu girdiğinizden emin olunuz!!!", "Uyuşmazlık Hatası");
        }

        private void UyeOlForm_Load(object sender, EventArgs e)
        {

        }
    }
}

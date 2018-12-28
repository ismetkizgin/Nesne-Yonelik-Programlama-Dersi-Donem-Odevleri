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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        Musteri musteri = new Musteri();

        private string[] yoneticiler = new string[0];
        private string[] sifre = new string[0];
        private string[] rutbe = new string[0];
        private string[] musteri_kodu = new string[0];

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void giris_kontrol()
        {
            StreamReader oku = MetinIslemleri.sr(@"belgeler\\giris.txt");

            string satir = oku.ReadLine();
            int i = 0;
            while (satir != null)
            {
                if (i % 4 == 0)
                {
                    Array.Resize(ref yoneticiler, yoneticiler.Length + 1);
                    yoneticiler[yoneticiler.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
                else if (i % 4 == 1)
                {
                    Array.Resize(ref sifre, sifre.Length + 1);
                    sifre[sifre.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
                else if (i % 4 == 2)
                {
                    Array.Resize(ref rutbe, rutbe.Length + 1);
                    rutbe[rutbe.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
                else
                {
                    Array.Resize(ref musteri_kodu, musteri_kodu.Length + 1);
                    musteri_kodu[musteri_kodu.Length - 1] = satir;
                    satir = oku.ReadLine();
                }
                i++;
            }
            oku.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            giris_kontrol();
            for (int i = 0; i < yoneticiler.Length; i++)
            {
                if (txtKullaniciAdi.Text == yoneticiler[i] && txtParola.Text == sifre[i])
                {
                    musteri.musteri_kodu = musteri_kodu[i];
                    musteri.rutbe = rutbe[i];
                    PanelForm frm = new PanelForm();
                    frm.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    if (i == yoneticiler.Length -1)
                    {
                        MessageBox.Show("Kullanıcı bilgilerini doğru girdiğinizden emin olunuz !","Hatalı Giriş");
                    }
                }
            }
        }

        private void lblUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlForm frm = new UyeOlForm("0");
            frm.ShowDialog();
        }
    }
}

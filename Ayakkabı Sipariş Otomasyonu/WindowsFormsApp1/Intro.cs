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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;

            if (saniye > 20)
            {
                Giris frm = new Giris();
                frm.Show();
                this.Close();
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

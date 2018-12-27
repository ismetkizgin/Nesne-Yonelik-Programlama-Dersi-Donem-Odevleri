using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cek : Odeme
    {
        private static string CekSahibi;
        private static string Banka;
        private static bool Yetki;
        private static decimal Tutar;
        public string ceksahibi { get { return CekSahibi; } set { CekSahibi = value; } }
        public string banka { get { return Banka; } set { Banka = value; } }
        public bool yetki
        {
            get
            {
                if (Tutar >= 1000)
                    Yetki = true;
                else
                    Yetki = false;

                return Yetki;
            }
            private set { }
        }
        public override decimal tutar { get { return Tutar + (Tutar * 2 / 100); } set { Tutar = value; } }
    }
}

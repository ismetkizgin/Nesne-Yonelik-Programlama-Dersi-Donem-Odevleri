using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class KrediKarti : Odeme
    {
        private static string HesapNo;
        private static string Taksit;
        private static string Tarih;
        private static decimal Tutar;
        public string hesapno { get { return HesapNo; } set { HesapNo = value; } }
        public string taksit { get { return Taksit; } set { Taksit = value; } }
        public DateTime sk_tarihi { get { return Convert.ToDateTime(Tarih); } set { Tarih = value.ToString(); } }
        public override decimal tutar { get { return Tutar; } set { Tutar = value + (value * (2 * Convert.ToDecimal(taksit) / 100)); } }
        public bool yetki
        {
            get
            {
                if (sk_tarihi < DateTime.Now)
                    return false;
                else
                    return true;
            }
            private set { }
        }
    }
}
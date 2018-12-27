using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Nakit : Odeme
    {
        private static string adsoyad;
        public string n_veren_kisi { get { return adsoyad; } set { adsoyad = value; } }
    }
}

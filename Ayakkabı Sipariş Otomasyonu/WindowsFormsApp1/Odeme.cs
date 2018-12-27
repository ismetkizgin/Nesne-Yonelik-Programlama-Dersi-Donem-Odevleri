using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Odeme 
    {
        private static int OdemeTürü;
        private static decimal Tutar;
        public int odemetürü { get { return OdemeTürü; } set { OdemeTürü = value; } }
        public virtual decimal tutar { get { return Tutar; } set { Tutar = value; } }
    }
}

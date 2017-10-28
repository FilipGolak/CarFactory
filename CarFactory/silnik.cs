using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFactory
{
    class silnik
    {
        private int spalanie = 0;
        public int ilość_paliwa = 0;
        public int pojemnosc = 0 ;
        public int dystans;
        public int obliczspalanie()
        {
            spalanie = 8;// pojemnosc / 200;
            return spalanie;
        }

        public int sprawdzdystans()
        {
            dystans = (ilość_paliwa * 100) / obliczspalanie();
            return dystans;
            
        }
        
    }
}

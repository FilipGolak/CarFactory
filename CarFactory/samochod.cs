using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFactory
{
    class samochod
    {
        public int dystans;
        public int pojemnosc_baku;
        public int jedz()
        {
            silnik silnik = new silnik();
            silnik.obliczspalanie();
            if (silnik.sprawdzdystans() < dystans)
            {
                MessageBox.Show("Nie dojedziesz do celu bez tankowania");
            }
            silnik.sprawdzdystans();
            return dystans--;

        }
    }


}

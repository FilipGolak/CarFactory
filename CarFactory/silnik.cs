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
        public static int pojemnosc_silnika;
        public static int pojemnosc_baku;
        public static double obliczspalanie()
        {

            double spalanie = pojemnosc_silnika / 200;
            return spalanie;
        }        
    }
}

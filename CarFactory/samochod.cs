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
        public static string Model;
        public static string Marka;
        public static double poziom_paliwa;
        public static  void jedz(ListBox lbDroga,TextBox ile_w_baku, int dystans)
        {
            for (int i = 1; i < dystans; i++)
            {
                if (poziom_paliwa < 1)
                {
                    lbDroga.Items.Add("Przejechałeś " + i + " km");
                    lbDroga.Items.Add("Zbiornik pusty, nigdzie nie jadę!");
                    ile_w_baku.Text = "0";
                    poziom_paliwa = 0;
                    return;
                }
                else
                {
                    poziom_paliwa =  Math.Round(poziom_paliwa - (1 * silnik.obliczspalanie() / 100),2);
                }
            }
            lbDroga.Items.Add("Przejechałeś " + dystans + " km");
            lbDroga.Items.Add("Dojechałeś do celu");
            ile_w_baku.Text = Math.Round(poziom_paliwa).ToString();
        }

        public static void zatankuj(ListBox lbDroga,TextBox tbIle_wBaku, int ilosc_paliwa)
        {
            if (ilosc_paliwa + poziom_paliwa >= silnik.pojemnosc_baku)
            {
                
                lbDroga.Items.Add("Zatankowano " + (silnik.pojemnosc_baku - Math.Round(poziom_paliwa)).ToString() + " litrów");
                poziom_paliwa = silnik.pojemnosc_baku;
                tbIle_wBaku.Text = silnik.pojemnosc_baku.ToString();
            }
            else
            {
                poziom_paliwa += ilosc_paliwa;
                lbDroga.Items.Add("Zatankowano " + ilosc_paliwa + " litrów");
                tbIle_wBaku.Text = poziom_paliwa.ToString();
            }
        }

        public static string pobierz_dane()
        {
            return Marka + " " + Model;
        }

        public static double sprawdz_dystans()
        {
            return poziom_paliwa * 100 / silnik.obliczspalanie(); ;
        }
    }
}

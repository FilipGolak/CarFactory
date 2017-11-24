using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFactory
{
    public partial class Form1 : Form
    {
        public string asd = "";
        public Form1()
        {
            //zasieg na górze dynamiczny
            //Muszą ubywąc litry po trasie
            InitializeComponent();
            tbMarka.Text = "Ford";
            tbModel.Text = "Focus";
            tbSilnik.Text = "1800";
            tbBak.Text = "55";
            tbIle_wBaku.Text = "15";
        }

        private void btJedz_Click(object sender, EventArgs e)
        {
            if (btJedz.Text == "Start")
            {
                tbSilnik.Enabled = false;
                tbMarka.Enabled = false;
                tbModel.Enabled = false;

                samochod.Marka = tbMarka.Text;
                samochod.Model = tbModel.Text;
                silnik.pojemnosc_silnika = int.Parse(tbSilnik.Text);
                silnik.pojemnosc_baku = int.Parse(tbBak.Text);
                samochod.poziom_paliwa = int.Parse(tbIle_wBaku.Text);
                groupBox1.Visible = true;
                lbDroga.Items.Add("Zaczynamy: " + samochod.pobierz_dane());
                lbDroga.Items.Add("Maksymalny zasięg: " + Math.Round(samochod.sprawdz_dystans(), 0) + "km");
                btJedz.Text = "Stop";
                tbZasieg.Text = Math.Round(samochod.sprawdz_dystans()).ToString();
            }
            else
            {
                btJedz.Text = "Start";
                lbDroga.Items.Add("Koniec Jazdy");
                groupBox1.Visible = false;
                tbSilnik.Enabled = true;
                tbMarka.Enabled = true;
                tbModel.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            samochod.jedz(lbDroga,tbIle_wBaku, int.Parse(tbDystans.Text));
            tbZasieg.Text = Math.Round(samochod.sprawdz_dystans()).ToString();
            tbDystans.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            samochod.zatankuj(lbDroga, tbIle_wBaku, int.Parse(tbTankuj.Text));
            tbZasieg.Text = Math.Round(samochod.sprawdz_dystans()).ToString();
            tbTankuj.Text = "";
        }
    }
}
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btJedz_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            samochod sam = new samochod();
            silnik silnik = new silnik();
            silnik.dystans = int.Parse(tbDystans.Text);
            silnik.pojemnosc = int.Parse(tbSilnik.Text);
            sam.dystans = int.Parse(tbDystans.Text);
            for (int i = 0; i < int.Parse(tbDystans.Text); i++)
            {
                lbDroga.Items.Add(sam.jedz());
                
            }
            
            //sam.jedz(int.Parse(tbDystans.Text));
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja_jedzenie_lab2
{
    public partial class Form4 : Form
    {
        Form1? ekranPoczatkowy;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Form1 ekranPoczatkowy)
        {
            InitializeComponent();
            this.ekranPoczatkowy = ekranPoczatkowy;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string transport = "";
            double cenaDostawy = 0;

            if (checkBox1.Checked == true)
            {
                transport += "Odbiór własny ";
            }
            if (checkBox2.Checked == true)
            {
                transport += "Dostawa kurierem ";
                cenaDostawy += 12; 
            }
            if (checkBox3.Checked == true)
            {
                transport += "+ opakowanie ECO ";
                cenaDostawy += 3; 
            }
            if (checkBox4.Checked == true)
            {
                transport += "+ dodatkowe sztućce ";
                cenaDostawy += 1; 
            }

            ekranPoczatkowy?.UstawSposobTransportu(transport, cenaDostawy);

            this.Close();
        }
    }
}

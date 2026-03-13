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
    public partial class Form2 : Form
    {
        Form1? ekranPoczatkowy;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 ekranPoczatkowy)
        {
            InitializeComponent();
            this.ekranPoczatkowy = ekranPoczatkowy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ekranPoczatkowy?.UstawSposobPlatnosci("Przelew");
            }
            else if (radioButton2.Checked == true)
            {
                ekranPoczatkowy?.UstawSposobPlatnosci("BLIK");
            }
            else if (radioButton3.Checked == true)
            {
                ekranPoczatkowy?.UstawSposobPlatnosci("Apple Pay");
            }
            else if (radioButton4.Checked == true)
            {
                ekranPoczatkowy?.UstawSposobPlatnosci("Gotówka");
            }
                this.Close();
        }
    }
}

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
    public partial class Form3 : Form
    {
        Form1? ekranPoczatkowy;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 ekranPoczatkowy)
        {
            InitializeComponent();
            this.ekranPoczatkowy = ekranPoczatkowy;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem zaznaczony in listView1.SelectedItems)
                {
                    string nazwa = zaznaczony.Text;
                    string cenaTekst = zaznaczony.SubItems[1].Text;

                    if (double.TryParse(cenaTekst, out double cena))
                    {
                        ekranPoczatkowy?.DodajProdukt(nazwa, cena);
                    }
                }
            }
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem zaznaczony in listView1.SelectedItems)
                {
                    string nazwa = zaznaczony.Text;
                    string cenaTekst = zaznaczony.SubItems[1].Text;

                    if (double.TryParse(cenaTekst, out double cena))
                    {
                        ekranPoczatkowy?.UsunProdukt(nazwa, cena);
                    }
                }
            }
        }
    }
}

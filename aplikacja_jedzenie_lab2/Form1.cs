namespace aplikacja_jedzenie_lab2
{
    public partial class Form1 : Form
    {
        private double calkowitaCena = 0; // Zmienna do trzymania sumy jedzenia
        private double cenaTransportu = 0; // Zmienna do trzymania kosztów dostawy

        public Form1()
        {
            InitializeComponent();
            AktualizujEtykieteCeny();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 dodawanieProduktu = new Form3(this);
            dodawanieProduktu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 wyborTransportu = new Form4(this);
            wyborTransportu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 wyborPlatnosci = new Form2(this);
            wyborPlatnosci.Show();
        }

        public void UstawSposobPlatnosci(string wybranaPlatnosc)
        {
            label3.Text = $"P³atnoœæ: {wybranaPlatnosc}";
        }

        private void AktualizujEtykieteCeny()
        {
            double lacznyKoszt = calkowitaCena + cenaTransportu;
            label1.Text = $"Cena ca³kowita: {lacznyKoszt} z³";
        }

        public void DodajProdukt(string nazwaProduktu, double cenaProduktu)
        {
            listView1.Items.Add(nazwaProduktu);

            calkowitaCena += cenaProduktu;
            AktualizujEtykieteCeny();
        }

        public void UsunProdukt(string nazwaProduktu, double cenaProduktu)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == nazwaProduktu)
                {
                    listView1.Items.Remove(item);
                    calkowitaCena -= cenaProduktu;

                    if (calkowitaCena < 0) calkowitaCena = 0;

                    AktualizujEtykieteCeny();

                    break;
                }
            }
        }
        public void UstawSposobTransportu(string transport, double cenaDostawy)
        {
            label2.Text = $"Sposób dostawy: {transport}";

            cenaTransportu = cenaDostawy;
            AktualizujEtykieteCeny();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

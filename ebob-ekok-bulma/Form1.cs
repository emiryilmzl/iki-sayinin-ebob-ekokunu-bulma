namespace ebob_ekok_bulma
{
    public partial class Form1 : Form
    {
        int deger1, deger2, enBuyuk, eKok, eBob;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger1 = Convert.ToInt32(sayi1.Text);
            deger2 = Convert.ToInt32(sayi2.Text);
            enBuyuk = deger1 * deger2;
            for (int i = enBuyuk; i>=1; --i)
            {
                if (i % deger1 == 0 && i % deger2 == 0)
                    eKok = i;
            }
            ekokSonuc.Text = Convert.ToString(eKok);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1.Clear();
            sayi2.Clear();
            ebobSonuc.Text = "";
            ekokSonuc.Text = "";
        }

        private void ebob_Click(object sender, EventArgs e)
        {
            deger1 = Convert.ToInt32(sayi1.Text);
            deger2 = Convert.ToInt32(sayi2.Text);
            if (deger1 > deger2)
                enBuyuk = deger1;
            else
                enBuyuk = deger2;
            for (int i = 1; i <= enBuyuk; ++i)
            {
                if (deger1 % i == 0 && deger2 % i == 0)
                    eBob = i;
            }
            ebobSonuc.Text = Convert.ToString(eBob);
        }

        private void sayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekokSonuc_Click(object sender, EventArgs e)
        {
        }
    }
}

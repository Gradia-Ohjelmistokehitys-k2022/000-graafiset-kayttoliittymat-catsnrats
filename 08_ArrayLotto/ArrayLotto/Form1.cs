namespace ArrayLotto
{
    public partial class Form1 : Form
    {
        private Random random = new Random(); // 'Random' -objekti arvotuille numeroille
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArpa_Click(object sender, EventArgs e)
        {
            // taulukot p‰‰- ja lis‰numeroille
            int[] p‰‰Numerot = ArvoNumerot(7);
            int[] lis‰Numerot = ArvoNumerot(2, p‰‰Numerot);

            // taulukko RichTextBoxien tarkistukseen
            RichTextBox[] tarkistettavatBoxit = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox4, richTextBox5, richTextBox6, richTextBox7 };

            // lihavoidut, osuneet numerot
            KorostaOsuneetNumerot(tarkistettavatBoxit, p‰‰Numerot, lis‰Numerot);

            // n‰ytt‰‰ arvotut numerot label- elementiss‰
            labelNumerot.Text = $"P‰‰numerot: {string.Join(", ", p‰‰Numerot)}\nLis‰numerot: {string.Join(", ", lis‰Numerot)}";
        }

        // metodi rivien arvontaan
        private int[] ArvoNumerot(int luku, params int[] eiNumerot)
        {
            int[] numerot = new int[luku];

            // arpoo 7 numeroa
            for (int i = 0; i < luku; i++)
            {
                int satunnaisLuku;
                do
                {
                    // generoi satunnaisluvun v‰lilt‰ 1 - 40
                    satunnaisLuku = random.Next(1, 41);

                    /* Etsii taulukosta 'numerot' lukua 'satunnaisLuku'. Jos tulos on -1, lukua ei lˆytynyt. 
                        Mik‰li 'if not': 'satunnaisLuku' on taulukossa -> looppi generoi uuden luvun. */
                } while (Array.IndexOf(numerot, satunnaisLuku) != -1);

                numerot[i] = satunnaisLuku;
            }
            return numerot;
        }

        // metodi osuneiden numeroiden tarkistamiseen ja esitt‰miseen
        /* Koodin pit‰isi lihavoida "osunut" numero samaan tekstikentt‰‰n mihin k‰ytt‰j‰ kirjoitti rivins‰ */
        private void KorostaOsuneetNumerot(RichTextBox[] textBoxes, int[] p‰‰Numerot, int[] lis‰Numerot)
        {
            foreach (RichTextBox richTextBox in textBoxes) // iteroi textBoxes -taulukon (RichTextBox)
            {
                // k‰ytt‰j‰n syˆte muuttujaan 'rivi1'
                string rivi1 = richTextBox.Text;

                // Jakaa annetun rivin -> poistaa "v‰lilyˆnnit"
                string[] lottoRivi = rivi1.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // iteroi numerot taulukossa 'lottoRivi'
                foreach (string lottoNumero in lottoRivi)
                {                    
                    if (int.TryParse(lottoNumero, out int numero)) // yritt‰‰ parsia / konvertoi k‰ytt‰j‰n syˆtteen kokonaisluvuksi
                    {
                        // tarkistaa vastaako parsittu k‰ytt‰j‰n antama kokonaisluku p‰‰- tai lis‰numeroita
                        if (Array.IndexOf(p‰‰Numerot, numero) != -1 || Array.IndexOf(lis‰Numerot, numero) != -1)
                        {
                            // muuttujan 'lottoNumero' alkuindeksi muuttujaan 'alkuIndeksi'
                            int alkuIndeksi = richTextBox.Text.IndexOf(lottoNumero);

                            // lˆytyykˆ alkuindeksi RichTextBox:sta ?
                            if (alkuIndeksi != -1)
                            {
                                // Valitsee ja lihavoi osuneen numeron
                                richTextBox.Select(alkuIndeksi, lottoNumero.Length);
                                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
                            }            
                        }
                    }
                }                
            }            
        }

        private void buttonTyhjenn‰Rivit_Click(object sender, EventArgs e) // tyhjent‰‰ k‰ytt‰j‰n syˆtteet ja muotoilut
        {
            // tyhjent‰‰ tekstikent‰t
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            richTextBox7.Clear();
        }
    }
}

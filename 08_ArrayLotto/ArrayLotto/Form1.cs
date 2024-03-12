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

            // k‰ytt‰j‰n antama (tarkistettava) lottorivi muuttujaan 'rivi1'
            string rivi1 = textBoxRivi1.Text;

            // lihavoidut, osuneet numerot
            string osuneetNumerot = KorostaOsuneetNumerot(rivi1, p‰‰Numerot, lis‰Numerot);

            // n‰ytt‰‰ tuloksen samassa tekstiruudussa miss‰ arvottava rivikin
            textBoxRivi1.Text = osuneetNumerot;

            // n‰ytt‰‰ arvotut numerot label- elementiss‰
            labelNumerot.Text = $"P‰‰numerot: {string.Join(", ", p‰‰Numerot)}\nLis‰numerot: {string.Join(", ", lis‰Numerot)}";
        }

        // metodi rivien arvontaan
        private int[] ArvoNumerot(int luku, params int[] eiNumerot)
        {
            int[] numerot = new int[luku];

            // arpoo 7 p‰‰numeroa
            for (int i = 0; i < luku; i++)
            {
                int satunnaisLuku;
                do
                {
                    // generoi satunnaisluvun v‰lilt‰ 1 - 40
                    satunnaisLuku = random.Next(1, 41);

                    /* Etsii taulukosta 'p‰‰Numerot' lukua 'satunnaisLuku'. Jos tulos on -1, lukua ei lˆytynyt. 
                        Mik‰li 'if not': 'satunnaisLuku' on taulukossa -> looppi generoi uuden luvun. */
                } while (Array.IndexOf(eiNumerot, satunnaisLuku) != -1);

                numerot[i] = satunnaisLuku;
            }
            return numerot;
        }

        // metodi osuneiden numeroiden korostamiseen
        private string KorostaOsuneetNumerot(string rivi1, int[] p‰‰Numerot, int[] lis‰Numerot)
        {
            // jakaa k‰ytt‰j‰n antaman rivin erillisiksi numeroiksi
            string[] lottoRivi = rivi1.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // korostaa osuneen numeron
            foreach (string lottoNumero in lottoRivi)
            {
                int numero;
                if (int.TryParse(lottoNumero, out numero))
                {
                    if (Array.IndexOf(p‰‰Numerot, numero) != -1 || Array.IndexOf(lis‰Numerot, numero) != -1)
                    {
                        // korvaa osuneen numeron lihavoidulla
                        rivi1 = rivi1.Replace(lottoNumero, $"<b>{lottoNumero}</b>");
                    }
                }
            }

            return rivi1;
        }

        //arpoo lis‰numerot
        //    for (int i = 0; i<lis‰Numerot.Length; i++)
        //    {
        //        int satunnaisLuku;
        //        do
        //        {
        //            satunnaisLuku = random.Next(1, 41);
        //        } while (Array.IndexOf(p‰‰Numerot, satunnaisLuku) != -1 || Array.IndexOf(lis‰Numerot, satunnaisLuku) != -1); // duplikaattitarkistukset kummallekin taulukolle

        //        lis‰Numerot[i] = satunnaisLuku;
        //    }

//     n‰ytt‰‰ arvotut numerot label- elementiss‰
//    labelNumerot.Text = $"P‰‰numerot: {string.Join(", ", p‰‰Numerot)}\nLis‰numerot: {string.Join(", ", lis‰Numerot)}";
//}        

        private void buttonTarkista_Click(object sender, EventArgs e)
        {

        }
    }
}

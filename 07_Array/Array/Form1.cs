namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] lukuTaulukko; // taulukko tyyppiä kokonaisluku
        private void buttonLuoTaulukko_Click(object sender, EventArgs e)
        {
            // Syötteen tarkistus: Onko kokonaisluku ? / 'taulukonKoko'-muuttujan luonti suuremmalla kokonaisluvulla kuin nolla
            if (int.TryParse(textBoxKoko.Text, out int taulukonKoko) && taulukonKoko > 0)
            {
                lukuTaulukko = new int[taulukonKoko]; // luo taulukon

                // interaktiivisuutta käyttäjän syötteen suhteen
                MessageBox.Show($"Taulukko {taulukonKoko} muistipaikalla luotu.", "Taulukko luotu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ole hyvä ja tarkista, että annoit taulukoon kooksi kokonaisluvun.", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTallenna_Click(object sender, EventArgs e)
        {
            // onko taulukko luotu ?
            if (lukuTaulukko == null)
            {
                MessageBox.Show("Luo taulukko ensin.", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // taulukkoon syötettävälle numerolle...
            if (!int.TryParse(textBoxTNum.Text, out int tallennettuNum))
            {
                MessageBox.Show("Ole hyvä ja tarkista, että annoit kokonaisluvun.", "Talletettava luku !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // taulukosta valittavalle indeksille...
            if (!int.TryParse(textBoxTInd.Text, out int indeksi))
            {
                MessageBox.Show("Anna kokonaisluku indeksille.", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // tarkistus, onko indeksi taulukon rajoissa
            if (indeksi < 0 || indeksi >= lukuTaulukko.Length)
            {
                MessageBox.Show($"Tarkista talletuspaikan indeksi. Indeksin pitää olla väliltä 0 ja {lukuTaulukko.Length - 1}", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // tallettaa numeron indeksiin
            lukuTaulukko[indeksi] = tallennettuNum;

            MessageBox.Show($"Numero {tallennettuNum} tallennettu taulukon indeksiin {indeksi}", "Luku tallennettu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHaku_Click(object sender, EventArgs e)
        {
            // onko taulukko luotu ?
            if (lukuTaulukko == null)
            {
                MessageBox.Show("Luo taulukko ensin.", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // taulukosta valittavalle indeksille...
            if (!int.TryParse(textBoxHakuTInd.Text, out int indeksi))
            {
                MessageBox.Show("Anna kokonaisluku.", "Haettu indeksi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // tarkistus, onko haettu indeksi taulukon rajoissa
            if (indeksi < 0 || indeksi >= lukuTaulukko.Length)
            {
                MessageBox.Show($"Tarkista haettu indeksi. Indeksin pitää olla väliltä 0 ja {lukuTaulukko.Length - 1}", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // numero haetusta indeksistä muuttujaan
            int hakuTulos = lukuTaulukko[indeksi];

            // näytetään löydetty numero
            labelHakuTulos.Text = $"Numero indeksissä {indeksi} on {hakuTulos}";
        }
    }
}

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

        // kokeilin try-catchia vain täällä, numeron haussa
        private void buttonHaku_Click(object sender, EventArgs e)
        {
            // onko taulukko luotu ?
            if (lukuTaulukko == null)
            {
                MessageBox.Show("Luo taulukko ensin.", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // try-catchilla syötteen tarkistus
            try
            {
                // parsii syötteen
                int indeksi = int.Parse(textBoxHakuTInd.Text);

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
            catch (FormatException) // syötteen tarkitus, kirjaimet ym.
            {
                MessageBox.Show("Tarkista annoitko kokonaisluvun indeksille.");
            }
            // Mikäli käyttäjä syöttää luvun mikä ei mahdu tyyppiin 'int': Int32.MaxValue tai Int32.MinValue (-2,147,483,648 to 2,147,483,647)
            catch (OverflowException)
            {
                MessageBox.Show("Annettu luku on liian suuri tai liian pieni.");
            }
            catch (Exception ex) // muille virheille ja poikkeuksille
            {
                MessageBox.Show($"VIRHE:\n\n {ex}.");
            }            
        }
    }
}

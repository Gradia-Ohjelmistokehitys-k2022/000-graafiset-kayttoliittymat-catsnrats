namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] lukuTaulukko; // taulukko tyyppi� kokonaisluku
        private void buttonLuoTaulukko_Click(object sender, EventArgs e)
        {
            // Sy�tteen tarkistus: Onko kokonaisluku ? / 'taulukonKoko'-muuttujan luonti suuremmalla kokonaisluvulla kuin nolla
            if (int.TryParse(textBoxKoko.Text, out int taulukonKoko) && taulukonKoko > 0)
            {
                lukuTaulukko = new int[taulukonKoko]; // luo taulukon

                // interaktiivisuutta k�ytt�j�n sy�tteen suhteen
                MessageBox.Show($"Taulukko {taulukonKoko} muistipaikalla luotu.", "Taulukko luotu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ole hyv� ja tarkista, ett� annoit taulukoon kooksi kokonaisluvun.", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // taulukkoon sy�tett�v�lle numerolle...
            if (!int.TryParse(textBoxTNum.Text, out int tallennettuNum))
            {
                MessageBox.Show("Ole hyv� ja tarkista, ett� annoit kokonaisluvun.", "Talletettava luku !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Tarkista talletuspaikan indeksi. Indeksin pit�� olla v�lilt� 0 ja {lukuTaulukko.Length - 1}", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Tarkista haettu indeksi. Indeksin pit�� olla v�lilt� 0 ja {lukuTaulukko.Length - 1}", "H U O M !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // numero haetusta indeksist� muuttujaan
            int hakuTulos = lukuTaulukko[indeksi];

            // n�ytet��n l�ydetty numero
            labelHakuTulos.Text = $"Numero indeksiss� {indeksi} on {hakuTulos}";
        }
    }
}

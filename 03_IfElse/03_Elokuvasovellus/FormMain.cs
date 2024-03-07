using System;

namespace Elokuvasovellus
{
    public partial class FormMain : Form
    {
        // oletusarvoja
        string elokuvanNimi = "[Syötä elokuvan nimi]";
        string elokuvanArvio = "[Kirjoita arvostelu tähän]";
        int elokuvanPituusMin = 0;
        string kuluvaVuosi = DateTime.Now.Year.ToString(); // kuluva vuosi merkkijonoon

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTallenna_Click(object sender, EventArgs e) // tallenna-painnikkeen toiminto
        {
            int i; // muuttuja textBoxien numerotarkistelujen avuksi

            // elokuvan tietojen if / else if -tarkistukset
            if (textBoxNimi.Text == "" || textBoxNimi.Text == elokuvanNimi)
            {
                MessageBox.Show("Elokuvan nimikenttä ei voi olla tyhjä.", "Elokuvan nimi.");
            }
            else if (!int.TryParse(textBoxJulkaisuvuosi.Text, out i))
            {
                MessageBox.Show("Julkaisuvuosi voi olla vain numeroina.", "Julkaisuvuosi.");
            }
            else if (!int.TryParse(textBoxKesto.Text, out i) || textBoxKesto.Text == "0")
            {
                MessageBox.Show("Elokuvan pituus voi olla vain numeroina. Pituus ei voi olla nolla minuuttia.", "Elokuvan pituus.");
            }
            else // ja mikäli kentät sisältävät sallitut merkit
            {
                MessageBox.Show("Elokuvan tiedot OK.", "Elokuvan tiedot.");
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs args) //Tietoja-valikon info-painikkeen toiminta
        {
            string textOhjelmoijanNimi = "Tämän sovelluksen on tehnyt: Antti Seppänen";
            string title = "Info";

            MessageBox.Show(textOhjelmoijanNimi, title);
        }

        private void buttonUusiTietue_Click(object sender, EventArgs e) // uusi tietue -painikkeen toiminta
        {          
            // asettaa painiketta painaessa tekstit textBoxeihin
            textBoxID.Text = "0";
            textBoxNimi.Text = elokuvanNimi;
            textBoxJulkaisuvuosi.Text = kuluvaVuosi.ToString();
            textBoxKesto.Text = elokuvanPituusMin.ToString();
            richTextBoxArvio.Text = elokuvanArvio;
        }

        private void textBoxNimi_Click(object sender, EventArgs e) // tyhjentää txtBoxin kun käyttäjä klikkaa hiirellä sitä
        {
            textBoxNimi.Clear();
        }

        private void textBoxNimi_Leave(object sender, EventArgs e) // palauttaa oletustekstin, mikäli käyttäjä jättää ruudun tyhjäksi
        {
            if (textBoxNimi.Text == "")
            {
                textBoxNimi.Text = elokuvanNimi;
            }
        }

        private void textBoxKesto_Click(object sender, EventArgs e)
        {
            textBoxKesto.Clear();
        }

        // palauttaa oletusarvon mikäli käyttäjä jättäisi ruudun tyhjäksi
        private void textBoxKesto_Leave(object sender, EventArgs e)
        {
            if (textBoxKesto.Text == "")
            {
                textBoxKesto.Text = elokuvanPituusMin.ToString();
            }
        }
        private void richTextBoxArvio_Click(object sender, EventArgs e)
        {
            richTextBoxArvio.Clear();
        }
        private void richTextBoxArvio_Leave(object sender, EventArgs e)
        {
            if (richTextBoxArvio.Text == "")
            {
                richTextBoxArvio.Text = elokuvanArvio;
            }
        }

        private void textBoxJulkaisuvuosi_Click(object sender, EventArgs e)
        {
            textBoxJulkaisuvuosi.Clear();
        }

        private void textBoxJulkaisuvuosi_Leave(object sender, EventArgs e)
        {
            if (textBoxJulkaisuvuosi.Text == "")
            {
                textBoxJulkaisuvuosi.Text = kuluvaVuosi;
            }
        }
    }
}

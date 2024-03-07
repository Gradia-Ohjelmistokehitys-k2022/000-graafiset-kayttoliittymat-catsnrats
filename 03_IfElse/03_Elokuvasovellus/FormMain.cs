using System;

namespace Elokuvasovellus
{
    public partial class FormMain : Form
    {
        // oletusarvoja
        string elokuvanNimi = "[Sy�t� elokuvan nimi]";
        string elokuvanArvio = "[Kirjoita arvostelu t�h�n]";
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
                MessageBox.Show("Elokuvan nimikentt� ei voi olla tyhj�.", "Elokuvan nimi.");
            }
            else if (!int.TryParse(textBoxJulkaisuvuosi.Text, out i))
            {
                MessageBox.Show("Julkaisuvuosi voi olla vain numeroina.", "Julkaisuvuosi.");
            }
            else if (!int.TryParse(textBoxKesto.Text, out i) || textBoxKesto.Text == "0")
            {
                MessageBox.Show("Elokuvan pituus voi olla vain numeroina. Pituus ei voi olla nolla minuuttia.", "Elokuvan pituus.");
            }
            else // ja mik�li kent�t sis�lt�v�t sallitut merkit
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
            string textOhjelmoijanNimi = "T�m�n sovelluksen on tehnyt: Antti Sepp�nen";
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

        private void textBoxNimi_Click(object sender, EventArgs e) // tyhjent�� txtBoxin kun k�ytt�j� klikkaa hiirell� sit�
        {
            textBoxNimi.Clear();
        }

        private void textBoxNimi_Leave(object sender, EventArgs e) // palauttaa oletustekstin, mik�li k�ytt�j� j�tt�� ruudun tyhj�ksi
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

        // palauttaa oletusarvon mik�li k�ytt�j� j�tt�isi ruudun tyhj�ksi
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

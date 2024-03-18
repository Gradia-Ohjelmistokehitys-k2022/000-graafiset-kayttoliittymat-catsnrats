namespace Dictionary
{
    public partial class Form1 : Form
    {
        // dictionary 'ages' tallentamaan avain-arvo parit
        private Dictionary<string, int> ages;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLuoDictionary_Click(object sender, EventArgs e)
        {
            // Dictionary instanssi
            ages = new Dictionary<string, int>();
            MessageBox.Show("Dictionary luotu :)");
        }

        private void buttonAddKeyVal_Click(object sender, EventArgs e) // painike lis‰‰ key-value arvoparin dictionaryyn
        {
            // Tarkistus: Onko dictionary alustettu
            if (ages == null)
            {
                MessageBox.Show("Luo ensin dictionary", "H U O M !");
                return;
            }

            // noukkii arvoparit tekstikentist‰
            // Trim()-metodi est‰‰ "vahinko-tyhjien" p‰‰tym‰st‰ muuttujaan 'key'
            string key = textBoxKey.Text.Trim();
            int value;

            // Tarkistus: Onko 'value' kokonaisluku
            if (!int.TryParse(textBoxValue.Text, out value))
            {
                MessageBox.Show("Tarkista annoitko kokonaisluvun ?", "H U O M !");
                return;
            }

            // Tarkistus: Onko 'key' jo dictionaryssa
            if (ages.ContainsKey(key))
            {
                MessageBox.Show("'Key' on jo dictionaryssa. K‰yt‰ toista key-arvoa.", "K‰yt‰ toista keyt‰.");
                return;
            }

            // lis‰‰ arvopari dictionaryyn
            ages.Add(key, value);
            MessageBox.Show("Key-value arvopari lis‰tty dictionaryyn.");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // 'key' -arvo tekstikent‰st‰ muuttujaan
            string searchKey = textBoxSearchKey.Text;

            // Tarkistus: Onko etsitty 'key' dictionaryssa
            if (ages.ContainsKey(searchKey))
            {
                // n‰ytt‰‰ haettua keyt‰ vastaavan arvon label-komponentissa
                labelShowValue.Text = $"{ages[searchKey]}";
            }
            else 
            {
                // mik‰li arvoa ei lˆytyisi
                labelShowValue.Text = $"Avaimelle {searchKey} ei lˆytynyt paria.";
            }
        }
    }
}

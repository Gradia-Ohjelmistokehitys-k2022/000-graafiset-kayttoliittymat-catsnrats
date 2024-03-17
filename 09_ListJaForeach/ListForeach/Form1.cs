namespace ListForeach
{
    public partial class Form1 : Form
    {
        // lista merkkijonoille
        private List<string> stringList;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLuoLista_Click(object sender, EventArgs e)
        {
            // uusi List<string> instanssi
            stringList = new List<string>();

            // debuggailun iloksi
            stringList.Add("Ensimm‰inen testirivi");
            stringList.Add("Toinen testirivi");
            stringList.Add("Kolmas testirivi");

            // debuggaamisen iloksi ( debuggerin watch-toiminnon testausta )
            string listContents = string.Join("\n", stringList);
            MessageBox.Show("Lista merkkijonoista:\n\n" + listContents, "Lista merkkijonoista");

        }

        private void buttonAddString_Click(object sender, EventArgs e)
        {
            // Tarkistus: Onko k‰ytt‰j‰ luonut listan 'stringList
            if (stringList == null)
            {
                MessageBox.Show("Luo lista ennen merkkijonojen syˆtt‰mist‰.", "HUOM !");
            }

            // hakee merkkijonon tekstiruudusta
            string newString = textBoxAddString.Text;

            // lis‰‰ merkkijono listaan 'stringList'
            stringList.Add(newString);

            // n‰ytt‰‰ viestikent‰ss‰ uuden rivin
            MessageBox.Show($"Merkkijono {newString} lis‰tty listaan.", "Lis‰tty !");
        }

        private void buttonHaeLista_Click(object sender, EventArgs e) // n‰ytt‰‰ listan combo boxissa
        {
            // tyhjent‰‰ combo boxin
            comboBoxList.Items.Clear();

            // Tarkistus: Onko 'stringList' null tai tyhj‰
            if (stringList != null && stringList.Count > 0)
            {
                // lis‰‰ jokaisen stringList listan merkkijonon combo boxiin
                foreach (string item in stringList)
                {
                    comboBoxList.Items.Add(item);
                }
            }
            else 
            {
                // mik‰li 'stringList' on tyhj‰ tai null, n‰ytt‰‰ viestin combo boxissa
                comboBoxList.Items.Add("Merkkijonolista on tyhj‰.");
            }
        }
    }
}

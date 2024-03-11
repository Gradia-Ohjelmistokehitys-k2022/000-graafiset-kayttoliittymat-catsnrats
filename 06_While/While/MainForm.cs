namespace While
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStartWhile_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; // yes ja no-painikkeet messageboxille
            
            while (true) // while kunnes k�ytt�j� valitsee 'ei'
            {
                // MessageBox kysymysmerkki-ikonilla
                DialogResult result = MessageBox.Show("Kyll� / Ei", "Haluatko jatkaa ?", buttons, MessageBoxIcon.Question);


                if (result == DialogResult.No) // break p��tt�� loopin kun k�ytt�j� klikkaa 'Ei' -> sulkee MessageBoxin
                {
                    break;
                }
            }            
        }
    }
}

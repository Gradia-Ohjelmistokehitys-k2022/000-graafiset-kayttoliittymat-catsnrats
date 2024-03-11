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
            
            while (true) // while kunnes käyttäjä valitsee 'ei'
            {
                // MessageBox kysymysmerkki-ikonilla
                DialogResult result = MessageBox.Show("Kyllä / Ei", "Haluatko jatkaa ?", buttons, MessageBoxIcon.Question);


                if (result == DialogResult.No) // break päättää loopin kun käyttäjä klikkaa 'Ei' -> sulkee MessageBoxin
                {
                    break;
                }
            }            
        }
    }
}

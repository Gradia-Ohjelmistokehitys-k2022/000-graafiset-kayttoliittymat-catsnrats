namespace Switch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            // viiden painikkeen käsittely yhdessä ButtonClick metodissa

            Button button = (Button)sender;

            if (button != null)
            {
                switch (button.Name) // käytetty buttonin nimeä case-valinnoissa
                {
                    case "button1":
                        MessageBox.Show("Valinta 1", "Huom");
                        break;

                    case "button2":
                        MessageBox.Show("Valinta 2", "Huom");
                        break;

                    case "button3":
                        MessageBox.Show("Valinta 3", "Huom");
                        break;

                    case "button4":
                        MessageBox.Show("Valinta 4", "Huom");
                        break;

                    case "button5":
                        MessageBox.Show("Default", "Huom");
                        break;

                    default:
                        break;
                }
            }
        }

    }
}

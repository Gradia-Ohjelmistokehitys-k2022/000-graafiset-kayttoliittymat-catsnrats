namespace For
{
    public partial class MainForm : Form
    {
        private int maxNumber = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int maxNumber)) // tarkistaa onko käyttäjä syöttänyt numeron
            {
                // 'Task.Run' -metodi asettaa for-loopin käyttämään muuta säiettä kuin UI-säiettä ?
                await Task.Run(() =>
                {
                    for (int i = 1; i <= maxNumber; i++) // iteroi yhdestä alkaen käyttäjän antaman luvun loppuun
                    {             
                        // 'invoke' päivittää UI-elementit threadista jota for-loop käyttää
                        this.Invoke((Action)(() => label1.Text = i.ToString())); // päivittää label1:n kokonaislukumuuttujalla i

                        // kokeiltu opiskelumielessä miten formin koordinaatit saa näkymään
                        this.Invoke((Action)(() => labelKoordinaatit.Text = $"X: {Location.X}, Y: {Location.Y}"));
                        
                        System.Threading.Thread.Sleep(100); // 100ms paussi luo näkyvän viiveen laskuriin
                    }
                });
            }
            else // mikäli syöte jotain muuta kuin numero
            {
                MessageBox.Show("Kirjoita kokonaisluku tekstiruutuun.", "HUOM");
            }
        }
    }
}

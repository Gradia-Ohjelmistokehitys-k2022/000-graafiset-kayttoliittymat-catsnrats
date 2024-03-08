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
            if (int.TryParse(textBox1.Text, out int maxNumber)) // tarkistaa onko k�ytt�j� sy�tt�nyt numeron
            {
                // 'Task.Run' -metodi asettaa for-loopin k�ytt�m��n muuta s�iett� kuin UI-s�iett� ?
                await Task.Run(() =>
                {
                    for (int i = 1; i <= maxNumber; i++) // iteroi yhdest� alkaen k�ytt�j�n antaman luvun loppuun
                    {             
                        // 'invoke' p�ivitt�� UI-elementit threadista jota for-loop k�ytt��
                        this.Invoke((Action)(() => label1.Text = i.ToString())); // p�ivitt�� label1:n kokonaislukumuuttujalla i

                        // kokeiltu opiskelumieless� miten formin koordinaatit saa n�kym��n
                        this.Invoke((Action)(() => labelKoordinaatit.Text = $"X: {Location.X}, Y: {Location.Y}"));
                        
                        System.Threading.Thread.Sleep(100); // 100ms paussi luo n�kyv�n viiveen laskuriin
                    }
                });
            }
            else // mik�li sy�te jotain muuta kuin numero
            {
                MessageBox.Show("Kirjoita kokonaisluku tekstiruutuun.", "HUOM");
            }
        }
    }
}

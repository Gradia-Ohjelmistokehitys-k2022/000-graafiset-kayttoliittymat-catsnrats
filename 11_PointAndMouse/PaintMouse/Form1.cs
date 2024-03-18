namespace PaintMouse
{
    public partial class Form1 : Form
    {
        Point piste = new Point(925, 350); // Point objekti
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;

            // piirret‰‰n p‰‰...
            Graf.FillEllipse(Brushes.MediumAquamarine, piste.X - 4, piste.Y - 8, 49, 49);
            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // selk‰
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41, piste.X + 21, piste.Y + 131);

            // k‰det
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60, piste.X + 70, piste.Y + 60);

            // jalat
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X - 30, piste.Y + 181);
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X + 70, piste.Y + 181);

            // kutsutaan DrawCoordinates()-metodia
            DrawCordinates(Graf);
        }

        // DrawCordinates-metodi
        private void DrawCordinates(Graphics Graf)
        {
            // piirt‰‰ piirtokoordinaattien arvot n‰ytˆlle
            Graf.DrawString("(" + piste.X + ", " + piste.Y + ")", new Font("TimesNewRoman", 14, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), 450, 30);
        }

        private void buttonSetCoords_Click(object sender, EventArgs e)
        {
            // parsii X- ja Y-koordinaatit tekstikentist‰
            if (int.TryParse(textBoxX.Text, out int newX) && int.TryParse(textBoxY.Text, out int newY))
            {
                // p‰ivitt‰‰ tikku-ukon koordinaatit
                piste = new Point(newX, newY);

                // raapustaa formin uudestaan p‰ivitt‰‰kseen tikku-ukon paikan
                Invalidate();
            }
            else 
            {
                // mik‰li koordinaattien parsiminen ep‰onnistuu
                MessageBox.Show("Virheelliset koordinaatit. Kokeile uudestaan.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

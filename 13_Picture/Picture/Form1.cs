using System.Drawing;

namespace Picture
{
    public partial class Form1 : Form
    {
        private Bitmap bitmapHopo; // Bitmap-objekti kuvan tallennukseen
        private Point lastMousePos; // hiiren kursorin sijainnille
        private Point pictureHopoPos; // hopon kuvan sijainnille
        public Form1()
        {
            InitializeComponent();

            // formin "tupla-bufferointi" hopon kuvan raahaamisen aikaisen v‰lkkeen v‰hent‰miseen
            this.DoubleBuffered = true;

            // lataa kuvan projektin resursseista
            bitmapHopo = Properties.Resources.hopo;

            // bitmapHopon tausta l‰pin‰kyv‰ksi
            bitmapHopo.MakeTransparent(Color.Blue);

            // alustaa hiiren kursorin sijannin koordinaatteihin 0, 0 (x, y)
            lastMousePos = new Point(0, 0);

            // alustaa hopon kuvan sijainnin
            pictureHopoPos = new Point(0, 0);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // tarkistus hiiren napin klikkaukselle
            if (e.Button == MouseButtons.Left)
            {
                // kuva formille klikattuun paikkaan
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawImage(bitmapHopo, e.Location.X, e.Location.Y);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // piirt‰‰ bitmapin nykysijaintiinsa
            e.Graphics.DrawImage(bitmapHopo, pictureHopoPos);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // mik‰li hiiren vas. painike pohjassa
            {
                // laskee hiirell‰ raahaamisen et‰isyyden
                int deltaX = e.X - lastMousePos.X;
                int deltaY = e.Y - lastMousePos.Y;

                // p‰ivitt‰‰ hopon kuvan sijainnin
                pictureHopoPos.X += deltaX;
                pictureHopoPos.Y += deltaY;                

                Invalidate(); // formin uudelleenpiirto kuvan sijannin p‰ivityst‰ varten

                lastMousePos = e.Location; // hiiren kursorin sijainnin p‰ivitys muuttujaan 'lastMousePos'
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                lastMousePos = e.Location; // hiiren kursorin sijaintitiedon p‰ivitys
            }
        }

        // metodi bitmapin liikuttamiseen
        private Bitmap MoveBitmap(Bitmap bitmap, int deltaX, int deltaY)
        {
            Bitmap movedHopo = new Bitmap(bitmap.Width, bitmap.Height); // uusi Bitmap-luokan instanssi 'movedHopo'
            using (Graphics g = Graphics.FromImage(movedHopo)) // luo Gaphics-objektin 'g' liittyen 'movedHopo' bitmappiin
            {
                // 'bitmap' piirret‰‰n Graphics-luokan metodilla DrawImage formin vas. yl‰kulmaan
                g.DrawImage(bitmap, new Point(deltaX, deltaY));
            }
            return movedHopo; // palauttaa modatun bitmapin
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tetris.Model;


namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageSource[] tileImages = new ImageSource[]
        {
            new BitmapImage(new Uri("View/Assets/TileEmpty.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/TileCyan.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/TileBlue.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/TileOrange.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/TileYellow.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/TileGreen.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/TilePurple.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/TileRed.png", UriKind.Relative))
        };

        private readonly ImageSource[] blockImages = new ImageSource[] 
        {
            new BitmapImage(new Uri("View/Assets/Block-Empty.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/Block-I.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/Block-J.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/Block-L.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/Block-O.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/Block-S.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/Block-T.png", UriKind.Relative)),
            new BitmapImage(new Uri("View/Assets/Block-Z.png", UriKind.Relative))
        };

        private readonly Image[,] imageControls;

        private GameState gameState = new GameState();
        public MainWindow()
        {
            InitializeComponent();

            // piirtoalueen alustus KESKEN
            //imageControls = SetupGameCanvas(gameState.);
        }

        private Image[,] SetupGameCanvas(Model.Grid grid) 
        {
            Image[,] imageControls = new Image[Model.Grid.Width, Model.Grid.Height];

            // poistaa olemassa olevan piirtoalueen "lapsen" ? :D
            GameCanvas.Children.Clear();

            // looppi iteroi ruudukon solut
            for (int y = 0; y < Model.Grid.Height; y++) 
            {
                for (int x = 0; x < Model.Grid.Width; x++)
                {
                     // luo uuden Image -kontrollin solulle
                     Image image = new Image();

                    // oletuslähde tyhjän ruudun kuvalle
                    image.Source = tileImages[0];

                    // Image-kontrollin positio ja koko
                    image.Width = 25;
                    image.Height = 25;
                    Canvas.SetLeft(image, x * 25);
                    Canvas.SetTop(image, y * 25);

                    // Image-kontrolli piirtoalueelle
                    GameCanvas.Children.Add(image);

                    // Image-kontrolli -> imageControls-taulukkoon
                    imageControls[x, y] = image;
                }
            }
            return imageControls;
        }
    }
}
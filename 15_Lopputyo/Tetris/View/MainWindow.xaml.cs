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
        // GameState-luokan instanssi
        private GameState gameState;

        private readonly ImageSource[] tileImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets/TileEmpty.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileCyan.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileBlue.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileOrange.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileYellow.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileGreen.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TilePurple.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileRed.png", UriKind.Relative))
        };

        private readonly ImageSource[] blockImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets/Block-Empty.png", UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileCyan.png", UriKind.Relative)),                        
            //new BitmapImage(new Uri("Assets/Block-I.png", UriKind.Relative)),
            //new BitmapImage(new Uri("Assets/Block-J.png", UriKind.Relative)),
            //new BitmapImage(new Uri("Assets/Block-L.png", UriKind.Relative)),
            //new BitmapImage(new Uri("Assets/Block-O.png", UriKind.Relative)),
            //new BitmapImage(new Uri("Assets/Block-S.png", UriKind.Relative)),
            //new BitmapImage(new Uri("Assets/Block-T.png", UriKind.Relative)),
            //new BitmapImage(new Uri("Assets/Block-Z.png", UriKind.Relative))
        };

        private readonly Image[,] imageControls;        

        private const int blockSize = 25;
        public MainWindow()
        {
            InitializeComponent();

            gameState = new GameState();

            // piirtoalueen alustus
            imageControls = SetupGameCanvas(gameState.Grid);
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
                    image.Source = tileImages[4];                    

                    // Image-kontrollin positio ja koko
                    image.Width = 25;
                    image.Height = 25;
                    Canvas.SetTop(image, y * 25); // Canvas.SetTop(image, (y - 2) * 25);
                    Canvas.SetLeft(image, x * 25);

                    // Image-kontrolli piirtoalueelle
                    GameCanvas.Children.Add(image);

                    // Image-kontrolli -> imageControls-taulukkoon
                    imageControls[x, y] = image;                    
                }
            }
            return imageControls;
        }       

        //private void DrawGrid(Model.Grid grid) // ALKUPERÄINEN
        //{
        //    for (int y = 0; y < Model.Grid.Height; y++)
        //    {
        //        for (int x = 0; x < Model.Grid.Width; x++)
        //        {
        //            bool isOccupied = grid.IsCellOccupied(x, y); // tarkistaa onko ruutu vapaa / varattu
        //            int id = isOccupied ? 1 : 0; // 1 varatuille ruuduille, 0 vapaille

        //            imageControls[x, y].Source = isOccupied ? blockImages[id] : tileImages[4];

        //            // isOccupied arvon myöhemmät käsittelyt ?
        //            //if (isOccupied)
        //            //{
        //            //    // tee jotain
        //            //}
        //            //else
        //            //{
        //            //    // if not occupied
        //            //}
        //        }
        //    }
        //}

        private void DrawBlock(Tetromino block)
        {         
            int[,] shape = block.GetShape();
            Point position = block.GetPosition();

            // putsaa taustan ennen palikan piirtoa
            GameCanvas.Children.Clear();

            for (int y = 0; y < shape.GetLength(0); y++)
            {
                for (int x = 0; x < shape.GetLength(1); x++)
                {
                    // onko ruutu varattu?
                    if (shape[y, x] != 0) // y, x oikean muodon alkupos.
                    {
                        // luo kuva-kontrollin ? tetrominolle
                        Image blockImage = new Image();
                        blockImage.Source = blockImages[shape[y, x]]; // shape[y, x]                        

                        blockImage.Width = 25;
                        blockImage.Height = 25;                        

                        double left = (position.X + x) * blockSize;
                        double top = (position.Y + y) * blockSize;

                        Canvas.SetLeft(blockImage, left);
                        Canvas.SetTop(blockImage, top);

                        // asettaa tetrominon kankaalle
                        GameCanvas.Children.Add(blockImage);
                    }
                }
            }
        }

        private void Draw(GameState gameState) 
        {
            //DrawGrid(gameState.Grid);            
            DrawBlock(gameState.currentTetromino);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {            
            // nykyinen tetromino
            Tetromino currentTetromino = gameState.GetCurrentTetromino();

            // Tetrominojen liikutteluun näppäimet
            switch (e.Key)
            {
                case Key.Left:
                    currentTetromino.Move(-1, 0); // liike vasemmalle
                    //if (gameState.Grid.CanMoveToPosition(currentTetromino, -1, 0))
                    //{
                    //    currentTetromino.Move(-1, 0); // liike vasemmalle
                    //}
                    break;
                case Key.Right:
                    currentTetromino.Move(1, 0); // oikealle
                    //if (gameState.Grid.CanMoveToPosition(currentTetromino, 1, 0))
                    //{
                    //    currentTetromino.Move(1, 0); // oikealle
                    //}
                    break;
                case Key.Down:
                    currentTetromino.Move(0, 1); // alaspäin (nopeammin)
                    //if (gameState.Grid.CanMoveToPosition(currentTetromino, 0, 1))
                    //{
                    //    currentTetromino.Move(0, 1); // alaspäin (nopeammin)
                    //}
                    break;
                case Key.Up: // kääntää tetrominoa myötäpäivään                    
                     currentTetromino.RotateClockwise();                    
                    break;
                case Key.Z:
                    currentTetromino.RotateCounterClockwise();
                    break;
                default:
                    return;
            }
            Draw(gameState);            
        }

        private void GameCanvas_Loaded(object sender, RoutedEventArgs e)
        { 
            Draw(gameState);            
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        { }
    }
}
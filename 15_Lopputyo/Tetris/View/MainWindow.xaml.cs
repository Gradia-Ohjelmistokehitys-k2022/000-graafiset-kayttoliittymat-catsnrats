﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Tetris.Model;

namespace Tetris
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public GameState gameState;     // GameState-luokan instanssi   
        public Tetromino? currentTetromino;
        public Tetromino? stackedTetromino;
        private DispatcherTimer gameTimer;        

        private readonly ImageSource[] tileImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets/TileEmpty.png", UriKind.Relative)),
        };

        private readonly Image[,] imageControls;  

        private const int blockSize = 25;
        public MainWindow()
        {
            InitializeComponent();
            gameState = new GameState(this);            

            // piirtoalueen alustus
            imageControls = SetupGameCanvas(gameState.Grid);

            // ajastimen konffaus
            gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromMilliseconds(800);
            gameTimer.Tick += (sender, e) => gameState.GameTick(sender, e);
            gameTimer.Start();
        }

        private Image[,] SetupGameCanvas(Model.Grid grid)
        {
            Image[,] imageControls = new Image[Model.Grid.Width, Model.Grid.Height];
            
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
                    image.Width = blockSize;
                    image.Height = blockSize;
                    Canvas.SetTop(image, y * blockSize); // Canvas.SetTop(image, (y - 2) * 25);
                    Canvas.SetLeft(image, x * blockSize);

                    // Image-kontrolli piirtoalueelle
                    GameCanvas.Children.Add(image);

                    // Image-kontrolli -> imageControls-taulukkoon
                    imageControls[x, y] = image;
                }
            }
            return imageControls;
        }
        private void DrawGrid(Model.Grid grid)
        {
            GameCanvas.Children.Clear(); // putsaa pelialueen            

            foreach (var tetromino in gameState.tetrominos) 
            { 
                DrawBlock(tetromino);
            }
            //for (int y = 0; y < Model.Grid.Height; y++) // piirtää ruudukon
            //{
            //    for (int x = 0; x < Model.Grid.Width; x++)
            //    {
            //        if (grid.IsCellOccupied(x, y))
            //        {
            //            Rectangle rect = new Rectangle();
            //            rect.Stroke = Brushes.LightSteelBlue;
            //            rect.StrokeThickness = 1;
            //            rect.Width = blockSize;
            //            rect.Height = blockSize;

            //            double canvasX = x * blockSize;
            //            double canvasY = y * blockSize;

            //            Canvas.SetLeft(rect, canvasX);
            //            Canvas.SetTop(rect, canvasY);
            //            GameCanvas.Children.Add(rect);
            //        }
            //    }
            //}
        }

        private void DrawBlock(Tetromino block)
        {            
            int[,] shape = block.GetShape();
            Point position = block.GetPosition();            

            for (int y = 0; y < shape.GetLength(0); y++)
            {
                for (int x = 0; x < shape.GetLength(1); x++)
                {
                    int shapeValue = shape[y, x];
                    if (shapeValue >= 0 && shapeValue < gameState.blockImages.Length) // y, x oikean muodon alkupos.
                    {                        
                        // kuva tetron varatuille ruuduille                        
                        string blockImageSource = gameState.blockImages[shapeValue];

                        // luo kuva-kontrollin ? tetrominolle
                        Image blockImage = new Image();                        
                        blockImage.Source = new BitmapImage(new Uri(blockImageSource, UriKind.Relative));                    

                        blockImage.Width = blockSize;
                        blockImage.Height = blockSize;                        

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

        public void Draw(GameState gameState) 
        {
            DrawGrid(gameState.Grid);            

            if (gameState.currentTetromino != null) // piirrä putoava tetro sen uuteen positioon
            {                
                DrawBlock(gameState.currentTetromino);               
            }     
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {            
            // nykyinen tetromino
            Tetromino currentTetromino = gameState.GetCurrentTetromino();

            // Tetrominojen liikutteluun näppäimet
            switch (e.Key)
            {
                case Key.Left:
                    //currentTetromino.Move(-1, 0); // liike vasemmalle
                    if (gameState.Grid.CanMoveToPosition(currentTetromino, -1, 0))
                    {
                        currentTetromino.Move(-1, 0); // liike vasemmalle
                    }
                    break;
                case Key.Right:
                    //currentTetromino.Move(1, 0); // oikealle
                    if (gameState.Grid.CanMoveToPosition(currentTetromino, 1, 0))
                    {
                        currentTetromino.Move(1, 0); // oikealle
                    }
                    break;
                case Key.Down:
                    //currentTetromino.Move(0, 1); // alaspäin (nopeammin)
                    if (gameState.Grid.CanMoveToPosition(currentTetromino, 0, 1))
                    {
                        currentTetromino.Move(0, 1); // alaspäin (nopeammin)
                    }
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
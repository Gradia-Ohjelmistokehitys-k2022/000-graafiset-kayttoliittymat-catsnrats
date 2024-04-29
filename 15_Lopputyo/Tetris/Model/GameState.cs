using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Threading;
using static Tetris.MainWindow;

namespace Tetris.Model
{
    public class GameState
    {
        public Tetromino? currentTetromino;
        public Grid Grid { get; private set; }

        public GameState? gameState;        
        private MainWindow mainWindow;

        // Define tetromino shapes as arrays of integers
        private readonly int[][][] tetrominoShapes = new int[][][]
        {            
            // 0 / I
            new int[][]
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 }
            },

            // 1 / J
            new int[][]
            {
                new int[] { 2, 0, 0 },
                new int[] { 2, 2, 2 },
                new int[] { 0, 0, 0 }
            },

            // 2 / L
            new int[][]
            {
                new int[] { 0, 0, 3 },
                new int[] { 3, 3, 3 },
                new int[] { 0, 0, 0 }
            },

            // 3 / O
            new int[][]
            {
                new int[] { 4, 4 },
                new int[] { 4, 4 }
            },

            // 4 / S
            new int[][]
            {
                new int[] { 0, 5, 5 },
                new int[] { 5, 5, 0 },
                new int[] { 0, 0, 0 }
            },

            // 5 / T
            new int[][]
            {
                new int[] { 0, 6, 0 },
                new int[] { 6, 6, 6 },
                new int[] { 0, 0, 0 }
            },

            // 6 / Z
            new int[][]
            {
                new int[] { 7, 7, 0 },
                new int[] { 0, 7, 7 },
                new int[] { 0, 0, 0 }
            }
        };

        // Define block images corresponding to each tetromino shape
        public readonly string[] blockImages = new string[]
        {
            "Assets/Block-Empty.png", // 0 - ruuduille
            "Assets/TileCyan.png",   // I
            "Assets/TileBlue.png",   // J
            "Assets/TileOrange.png", // L
            "Assets/TileYellow.png", // O
            "Assets/TileGreen.png",  // S
            "Assets/TilePurple.png", // T
            "Assets/TileRed.png"     // Z
        };

        public GameState(MainWindow mainWindow)
        {
            // alustaa ruudukon
            Grid = new Grid();

            GenerateNewTetromino();
            this.mainWindow = mainWindow;
        }

        public string GetBlockImage(TetrominoShape shape)
        {
            return blockImages[(int)shape];
        }

        #pragma warning disable CS8603 // varoituksen CS8603 mitätöinti
        public Tetromino GetCurrentTetromino() 
        {
            return currentTetromino;
        }
        #pragma warning restore CS8603

        private void GenerateNewTetromino()
        {
            int randomIndex = new Random().Next(0, tetrominoShapes.Length);
            int[][] tetrominoShapeJagged = tetrominoShapes[randomIndex];
            int[,] tetrominoShape = new int[tetrominoShapeJagged.Length, tetrominoShapeJagged[0].Length];

            for (int i = 0; i < tetrominoShapeJagged.Length; i++)
            {
                for (int j = 0; j < tetrominoShapeJagged[0].Length; j++)
                {
                    tetrominoShape[i, j] = tetrominoShapeJagged[i][j];
                }
            }

            currentTetromino = new Tetromino(tetrominoShape);        
        }

        public void LockTetromino()
        {
            currentTetromino = null;
        }

        public void GameTick(object? sender, EventArgs e)
        {
            if (currentTetromino == null || gameState == null || gameState.Grid == null)
                return;

            // Move the current tetromino down
            if (gameState.Grid.CanMoveToPosition(currentTetromino, 0, 1))
            {
                currentTetromino.Move(0, 1);
            }
            else 
            {
                // If the tetromino can't move down, it's because it's either at the bottom or blocked by other tetrominos

                gameState.LockTetromino();

                bool foundCompleted = false;
                for (int row = Grid.Height - 1; row >= 0; row--)
                {
                    if (Grid.IsRowCompleted(row))
                    {
                        foundCompleted = true;
                        break; // mikäli rivi on täysi -> se pitäisi poistaa
                    }
                }

                if (foundCompleted)
                {
                    gameState.Grid.ClearCompletedRows();
                }
                
                gameState.GenerateNewTetromino();
            }

            // Redraw the game board
            mainWindow.Draw(this);
        }
    }

    public enum TetrominoShape
    {
        I,
        J,
        L,
        O,
        S,
        T,
        Z
    }
}

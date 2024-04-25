using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using static Tetris.MainWindow;

namespace Tetris.Model
{
    internal class GameState
    {
        public Tetromino currentTetromino;
        public Grid Grid { get; private set; }

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

        public GameState()
        {
            // alustaa ruudukon
            Grid = new Grid();

            int[][] tetrominoShapeJagged = tetrominoShapes[0];
            int[,] tetrominoShape = new int[tetrominoShapeJagged.Length, tetrominoShapeJagged[0].Length];

            for (int i = 0; i < tetrominoShapeJagged.Length; i++)
            {
                for (int j = 0; j < tetrominoShapeJagged[0].Length; j++)
                {
                    tetrominoShape[i, j] = tetrominoShapeJagged[i][j];
                }
            }

            // Set the current tetromino to the I tetromino
            currentTetromino = new Tetromino(tetrominoShape);            
        }

        public string GetBlockImage(TetrominoShape shape)
        {
            return blockImages[(int)shape];
        }

        public Tetromino GetCurrentTetromino() 
        {
            return currentTetromino;
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
    }}

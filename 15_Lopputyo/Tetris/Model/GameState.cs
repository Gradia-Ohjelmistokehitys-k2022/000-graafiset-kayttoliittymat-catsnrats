﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Threading;
using static Tetris.MainWindow;*/
using System.Windows;

namespace Tetris.Model
{
    public class GameState
    {
        public List<Tetromino> tetrominos;
        public Tetromino CurrentTetromino { get; private set; }

        public Tetromino? currentTetromino;
        public Tetromino? stackedTetromino;
        public Grid Grid { get; private set; }

        //public GameState? gameState;        
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
            "Assets/TileEmpty.png", // 0 - ruuduille
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
            tetrominos = new List<Tetromino>();

            // alustaa ruudukon
            Grid = new Grid();

            GenerateNewTetromino();
            this.mainWindow = mainWindow;
        }

        public string GetBlockImage(TetrominoShape shape) // onko tarpeellinen ?
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

        public void LockTetromino(Tetromino currentTetromino) // lukitsee tetron osuessaan pohjalle tai toisen päälle
        {
            foreach (Block block in currentTetromino.blocks)
            {
                int gridX = block.X;
                int gridY = block.Y;
                //Point point = new Point(gridX, gridY); // ei tarvita?
                Grid.SetCellOccupancy(gridX, gridY, true);
            }
            Grid.ClearCompletedRows();           
        }

        public void GameTick(object? sender, EventArgs e)
        {
            if (this.currentTetromino == null || this.Grid == null)
                return;

            // Move the current tetromino down
            if (this.Grid.CanMoveToPosition(this.currentTetromino, 0, 1))
            {
                this.currentTetromino.Move(0, 1);               
            }
            else 
            {
                // If the tetromino can't move down, it's because it's either at the bottom or blocked by other tetrominos

                this.LockTetromino(currentTetromino);

                bool foundCompleted = false;
                for (int row = Grid.Height - 1; row >= 0; row--)
                {
                    if (this.Grid.IsRowCompleted(row))
                    {
                        foundCompleted = true;
                        break; // mikäli rivi on täysi -> se pitäisi poistaa
                    }
                }

                if (foundCompleted)
                {
                    this.Grid.ClearCompletedRows();
                }
                
                this.GenerateNewTetromino();
            }

            // Redraw the game board
            mainWindow.Draw(this);
        }

        //public Tetromino? GetOccupyingTetromino(int x, int y)
        //{
        //    foreach (var tetromino in tetrominos)
        //    {
        //        if (Grid.IsCellOccupied(x, y))
        //        {  
        //            return tetromino;
        //        }
        //    }
        //    return null;
        //}
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

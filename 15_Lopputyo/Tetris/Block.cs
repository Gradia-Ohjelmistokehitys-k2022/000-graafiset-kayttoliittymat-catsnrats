using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Tetrominot: 
 * Tetrominojen position ja muodon määrittely */

namespace Tetris
{
    public class Block
    {
        // tetrominojen muodon määrittelyt
        //private static readonly int[,] IShape = { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 } };

        // IShape -> X -> cyan
        private static readonly char[,] IShape = {
            { '\u001b', '[', '3', '6', 'm', 'X', ' ', ' ', ' ' },
            { '\u001b', '[', '3', '6', 'm', 'X', ' ', ' ', ' ' },
            { '\u001b', '[', '3', '6', 'm', 'X', ' ', ' ', ' ' },
            { '\u001b', '[', '3', '6', 'm', 'X', ' ', ' ', ' ' }
        };

        private int[,] shape;
        private int pivotX;
        private int pivotY;
        private Board board;

        public Block(int[,] shape, int pivotX, int pivotY, Board board)
        {
            this.shape = shape;
            this.pivotX = pivotX;
            this.pivotY = pivotY;
            this.board = board;
        }

        public int[,] GetShape()
        {
            return shape;
        }

        public int GetPivotX()
        {
            return pivotX;
        }

        public int GetPivotY() 
        {
            return pivotY;
        }

        public static void DrawTetromino()
        {
            // asettaa konsolin tekstin väriksi syaanin
            Console.ForegroundColor = ConsoleColor.Cyan;

            // piirtää I-tetrominon
            for (int row = 0; row < IShape.GetLength(0); row++)
            {
                for (int col = 0; col < IShape.GetLength(1); col++)
                {
                    Console.Write(IShape[row, col]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void PlaceTetromino(Block tetromino)
        {
            // koordinaatit tetrominoille
            int[,] shape = tetromino.GetShape();
            int pivotX = tetromino.GetPivotX();
            int pivotY = tetromino.GetPivotY();

            // asettaisi tetrominon gridiin
            for (int row = 0; row < shape.GetLength(0); row++)
            {
                for (int col = 0; col < shape.GetLength(1); col++)
                {
                    int x = pivotX + row;
                    int y = pivotY + col;
                    
                    if (x >= 0 && x < Board.Height && y >= 0 && y < Board.Width)
                    {                        
                        board.grid[x, y] = (char)shape[row, col];                        
                    }
                }
            }
        }

        // metodit tetrominojen liikutteluun
        public void RotateClockWise()
        { }

        public void RotateCounterClockWise()
        { }

        public void MoveLeft()
        { }

        public void MoveRight() 
        { }

        public void MoveDown()
        { }

    }
}

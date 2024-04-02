using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Shapes;
using System.Windows;

namespace Tetris.Model
{
    internal class Tetromino
    {
        private List<Block> blocks = new List<Block>(); // lista palikoille
        private int[,] shape; // palikan muoto

        public Tetromino(int[,] shape)
        {
            this.shape = shape;
            InitializeBlocks();
        }

        private void InitializeBlocks()
        {           
            int rows = shape.GetLength(0);
            int cols = shape.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (shape[i, j] != 0)
                    {
                        blocks.Add(new Block(i, j)); // Create a block at position (i, j)
                    }
                }
            }
        }

        public int[,] GetShape() 
        {
            return shape;
        }

        public System.Windows.Point GetPosition() 
        {
            // palikoiden sijainti...
            int minX = blocks.Min(block => block.X);
            int minY = blocks.Min(block => block.Y);
            return new System.Windows.Point(minX, minY);
        }
        public void Move(int deltaX, int deltaY)
        {
            foreach (var block in blocks)
            {
                block.X += deltaX;
                block.Y += deltaY;
            }
        }
        public void RotateClockwise()
        {
            int[,] rotatedShape = new int[shape.GetLength(1), shape.GetLength(0)];
            int rows = shape.GetLength(0);
            int cols = shape.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rotatedShape[j, rows - i - 1] = shape[i, j];
                }
            }

            shape = rotatedShape;
            InitializeBlocks();
        }
        public void RotateCounterClockwise()
        {
            int[,] rotatedShape = new int[shape.GetLength(1), shape.GetLength(0)];
            int rows = shape.GetLength(0);
            int cols = shape.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rotatedShape[cols - j - 1, i] = shape[i, j];
                }
            }

            shape = rotatedShape;
            InitializeBlocks();
        }
    }
}
internal class Block
{
    public int X { get; set; }
    public int Y { get; set; }

    public Block(int x, int y)
    {
        X = x;
        Y = y;
    }
}

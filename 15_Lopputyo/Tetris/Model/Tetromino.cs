﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Shapes;
using System.Windows;

namespace Tetris.Model
{
    public class Tetromino
    {
        internal List<Block> blocks = new List<Block>(); // lista palikoille
        private int[,] shape; // palikan muoto
        
        public Tetromino(int[,] shape) // pelkän muodon konstruktori
        {
            this.shape = shape;
            InitializeBlocks();
        }

        public List<Point> GetOccupiedPositions()
        {
            return CalculateOccupiedPositions(shape);
        }

        private void InitializeBlocks()
        {   
            blocks.Clear(); // palikkaputsaus ennen init
            int rows = shape.GetLength(0);
            int cols = shape.GetLength(1);

            // massan / palikan keskipiste
            int centerX = cols / 2;
            int centerY = rows / 2;           

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    if (shape[x, y] != 0)
                    {
                        int blockX = x - centerX; // palikan positio suhteessa keskustaan
                        int blockY = y - centerY;
                        blocks.Add(new Block(blockX, blockY));                        
                    }
                }
            }
        }

        public int[,] GetShape() 
        {
            return shape;
        }

        public Point GetPosition() // originaali
        {
            // massan keskipiste
            double totalX = blocks.Sum(block => block.X + 0.5);
            double totalY = blocks.Sum(block => block.Y);

            double centerX = totalX / blocks.Count;
            double centerY = totalY / blocks.Count;

            return new Point(centerX, centerY);
        }      

        public void Move(int deltaX, int deltaY)
        {
            foreach (var block in blocks)
            {
                block.X += deltaX;
                block.Y += deltaY;
            }
        }

        private List<Point> CalculateOccupiedPositions(int[,] shape) // metodi "ykkösten" laskemiseen 4 x 4 tetrotaulukosta
        {
            List<Point> positions = new List<Point>();
            
            for (int y = 0; y < shape.GetLength(0); y++) 
            {
                for (int x = 0; x < shape.GetLength(1); x++)
                {
                    if (shape[x, y] == 1) // X ja Y oikein
                    {
                        positions.Add(new Point(x, y));
                    }
                }
            }
            return positions;
        }

        public void RotateClockwise()
        {            
            int rows = shape.GetLength(0);
            int cols = shape.GetLength(1);
            int[,] rotatedShape = new int[cols, rows];

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    rotatedShape[x, rows - y - 1] = shape[y, x];
                }
            }

            shape = rotatedShape;
            //InitializeBlocks();
        }
        public void RotateCounterClockwise()
        {            
            int rows = shape.GetLength(0);
            int cols = shape.GetLength(1);
            int[,] rotatedShape = new int[cols, rows];

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    rotatedShape[cols - x - 1, y] = shape[y, x];
                }
            }

            shape = rotatedShape;
            //InitializeBlocks();
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

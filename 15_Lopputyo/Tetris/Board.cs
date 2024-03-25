using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Board:
 * Tausta millä tetrominot liikkuvat */

namespace Tetris
{
    // Board-luokka piirtää taustan, jossa tetrominoja liikutellaan (pitäisi olla valmis / toimiva)
    public class Board
    {
        // pelilauta jossa tetrominoja liikutellaan
        public const int Width = 10; // pelilaudan leveys
        public const int Height = 20; // pelilaudan korkeus

        public char[,] grid; // 2D-taulukko

        public Board() 
        {
            // Alustaa pelilaudan
            grid = new char[Height, Width];
            for(int row = 0; row < Height; row++)
            {
                for(int col = 0; col < Width; col++) 
                {
                    grid[row, col] = ' ';
                }
            }
        }

        public void DrawBoard()
        { 
            // konsoli puhtaaksi ennen piirtoa
            Console.Clear();

            // piirtää pelilaudan
            for(int row = 0; row < Height; row++) 
            {
                for (int col = 0; col < Width; col++)
                {
                    Console.Write(grid[row, col] + ".");
                }
                Console.WriteLine();
            }
        }
    }
}

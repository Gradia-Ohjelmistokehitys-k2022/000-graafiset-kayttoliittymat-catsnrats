using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows;

namespace Tetris.Model
{
    public class Grid
    {
        // muuttujat ruudukon määrittelyyn
        public const int Width = 10;
        public const int Height = 20;       

        // 2D-taulukko kuvaamaan taustan ruudukkoa
        private readonly bool[,] gridCells;

        public Grid() 
        {
            // alustaa gridin
            gridCells = new bool[Width, Height];
        }

        // metodi tarkistamaan onko ruutu varattu
        public bool IsCellOccupied(int x, int y) 
        {
            if (x < 0 || x >= Width || y < 0 || y >= Height)
            {
                return true;
            }
            return gridCells[x, y];
        }

        public bool this[int x, int y] // indexer
        {
            get
            {
                if (x < 0 || x >= Width || y < 0 || y >= Height)
                {
                    return true;
                }
                return gridCells[x, y];
            }
            set 
            {
                if (x >= 0 && x < Width && y >= 0 && y < Height)
                {
                    gridCells[x, y] = value;
                }
            }
        }

        // metodi asettamaan ruutu varatuksi
        public void SetCellOccupancy(int x, int y, bool occupied)
        {
            if (x >= 0 && x < Width && y >= 0 && y < Height)
            {
                gridCells[x, y] = occupied;
            }
        }

        // metodi ruudukon tyhjentämiseen
        public void ClearGrid() 
        {
            Array.Clear(gridCells, 0, gridCells.Length);
        }

        // metodi tarkistamaan onko rivi täynnä
        public bool IsRowCompleted(int row) 
        {
            for (int x = 0; x < Width; x++)
            {
                if (!gridCells[x, row]) 
                {
                    return false; // mikäli rivi ei ole täysi
                }
            }
            return true; // mikäli rivi on täysi
        }

        // metodi poistamaan täydet rivit ja tiputtamaan rivejä alas
        public void ClearCompletedRows() 
        {
            for (int y = Height - 1; y >= 0; y--) 
            {
                if (IsRowCompleted(y)) 
                {
                    // hmmm ?
                    for (int i = y; i > 0; i--)
                    {
                        for (int x = 0; x < Width; x++) 
                        {
                            gridCells[x, i] = gridCells[x, i - 1];
                        }
                    }
                    // poistaa ylimmän rivin
                    for (int x = 0; x < Width; x++) 
                    {
                        gridCells[x, 0] = false;
                    }
                    y++; // "nykyrivin" uudelleen tarkistus ?
                }
            }
        }

        // Tetrominon liikkumisen rajaamista...
        // Onko palikka pelialueen sisällä
        public bool IsWithinBoundaries(int x, int y) 
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }

        // Onko alue tyhjä
        public bool IsCellEmpty(int x, int y) 
        {
            return IsWithinBoundaries(x, y) && !gridCells[x, y];
        }

        // Voiko Tetromino siirtyä pelaajan liikuttamaan sijaintiin törmäämättä...
        public bool CanMoveToPosition(Tetromino tetromino, int deltaX, int deltaY) 
        {
            System.Windows.Point currentPosition = tetromino.GetPosition();
            int[,] shape = tetromino.GetShape();            

            for (int y = 0; y < shape.GetLength(0); y++)
            {
                for (int x = 0; x < shape.GetLength(1); x++)
                {
                    if (shape[y, x] != 0)
                    {
                        int newX = (int)currentPosition.X + x + deltaX;
                        int newY = (int)currentPosition.Y + y + deltaY;

                        if (newX < 0 || newX >= Grid.Width || newY < 0 || newY >= Grid.Height)
                        {
                            return false;
                        }

                        if (!IsCellEmpty(newX, newY)) // IsCellEmpty ei tod.näk. toimi kuten pitäisi
                        {
                            return false; // törmää pelialueen reunaan tai toiseen palikkaan
                        }
                    }              
                }
            }
            return true;            
        }

        // päivittää gridiä pelaajan liikuttaessa pelikoita
        public void UpdateGrid(Tetromino tetromino) 
        {
            foreach (var block in tetromino.blocks) // putsaa palikoiden vanhan position
            {
                gridCells[block.X, block.Y] = false;
            }

            foreach (var block in tetromino.blocks) // merkkaa uudet positiot
            {
                gridCells[block.X, block.Y] = true;
            }
        }
    }
}

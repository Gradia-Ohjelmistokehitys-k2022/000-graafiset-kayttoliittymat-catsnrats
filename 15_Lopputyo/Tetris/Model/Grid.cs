﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Model
{
    public class Grid
    {
        // muuttujat ruudukon määrittelyyn
        public const int Width = 10;
        public const int Height = 20;

        // 2D-taulukko kuvaamaan ruudukkoa
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
    }
}

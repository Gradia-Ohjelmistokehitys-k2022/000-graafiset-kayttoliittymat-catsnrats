using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Tetris.Model
{
    internal class GameState
    {
        public Tetromino currentTetromino;
        public Grid Grid { get; private set; }

        public GameState()
        {
            // alustaa ruudukon
            Grid = new Grid();

            currentTetromino = new Tetromino(new int[,] // I-tetron alkupositio
            {
                { 0, 0, 0, 0 },
                { 1, 1, 1, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            });            

            //currentTetromino = new Tetromino(new int[,] // L-tetron alkupositio
            //{
            //    { 0, 0, 1, 0 },
            //    { 1, 1, 1, 0 },
            //    { 0, 0, 0, 0 },
            //    { 0, 0, 0, 0 }
            //});

            //currentTetromino = new Tetromino(new int[,] // S-tetron alkupositio
            //{
            //    { 0, 0, 0, 0 },
            //    { 0, 1, 1, 0 },
            //    { 1, 1, 0, 0 },
            //    { 0, 0, 0, 0 }
            //});

            //currentTetromino = new Tetromino(new int[,] // J-tetron alkupositio
            //{
            //    { 0, 0, 0, 0 },
            //    { 1, 0, 0, 0 },
            //    { 1, 1, 1, 0 },
            //    { 0, 0, 0, 0 }
            //});
        }

        public Tetromino GetCurrentTetromino() 
        {
            return currentTetromino;
        }        
    }
}

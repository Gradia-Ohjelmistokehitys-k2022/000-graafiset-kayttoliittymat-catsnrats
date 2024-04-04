using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //currentTetromino = new Tetromino(new int[,]
            //{
            //    { 1 },
            //    { 1 },
            //    { 1 },
            //    { 1 }
            //});

            //currentTetromino = new Tetromino(new int[,]
            //{
            //    { 0, 0, 1 },
            //    { 1, 1, 1 },
            //});
        }

        public Tetromino GetCurrentTetromino() 
        {
            return currentTetromino;
        }        
    }
}

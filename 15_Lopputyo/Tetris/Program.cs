/* ### Konsolissa pelattava Tetris. ### */

// Luokat on vielä alustavia suunnitelmiltaan (22.3.)
using System;
using Tetris;

public class MainClass
{
    // aloitettu luomalla "pelilauta"...
    public static void Main(string[] args)
    {
        // Board-luokan instanssi
        Board board = new Board();        

        // piirtää laudan
        board.DrawBoard();        

        Block.DrawTetromino();

        Console.ReadKey();
    }
}
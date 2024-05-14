using System;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Form1 : Form
    {
        private const int BoardWidth = 10;
        private const int BoardHeight = 20;
        private const int BlockSize = 25;
        private bool[,] board = new bool[BoardWidth, BoardHeight];
        private Point currentBlockPosition;
        private int[,] currentBlock;
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            currentBlock = GenerateRandomBlock(); // Initialize currentBlock
            this.Paint += Form1_Paint;
        }

        private void InitializeGame()
        {
            for (int x = 0; x < BoardWidth; x++)
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    board[x, y] = false;
                }
            }

            currentBlock = GenerateRandomBlock();
            currentBlockPosition = new Point(3, 0);

            gameTimer.Interval = 500;
            gameTimer.Tick += GameTick;
            gameTimer.Start();
        }

        private int[,] GenerateRandomBlock()
        {
            int[,] block = new int[4, 4];
            int blockType = random.Next(7);
            switch (blockType)
            {
                case 0: // O block
                    block = new int[,] { { 1, 1 }, { 1, 1 } };
                    break;
                case 1: // I block
                    block = new int[,] { { 1, 1, 1, 1 } };
                    break;
                case 2: // J block
                    block = new int[,] { { 1, 0, 0 }, { 1, 1, 1 } };
                    break;
                case 3: // L block
                    block = new int[,] { { 0, 0, 1 }, { 1, 1, 1 } };
                    break;
                case 4: // S block
                    block = new int[,] { { 0, 1, 1 }, { 1, 1, 0 } };
                    break;
                case 5: // T block
                    block = new int[,] { { 0, 1, 0 }, { 1, 1, 1 } };
                    break;
                case 6: // Z block
                    block = new int[,] { { 1, 1, 0 }, { 0, 1, 1 } };
                    break;
                default:
                    break;
            }
            return block;
        }

        private void GameTick(object? sender, EventArgs e)
        {
            if (!MoveBlock(0, 1))
            {
                MergeBlock();
                CheckForLines();
                currentBlock = GenerateRandomBlock();
                currentBlockPosition = new Point(3, 0);
                if (!MoveBlock(0, 1))
                {
                    gameTimer.Stop();
                    MessageBox.Show("Game Over");
                    InitializeGame();
                }
            }
            Refresh();
        }

        private bool MoveBlock(int deltaX, int deltaY)
        {
            Point newPosition = new Point(currentBlockPosition.X + deltaX, currentBlockPosition.Y + deltaY);

            if (IsBlockValid(currentBlock, newPosition))
            {
                currentBlockPosition = newPosition;
                return true;
            }

            return false;
        }

        private bool IsBlockValid(int[,] block, Point position)
        {
            int blockWidth = block.GetLength(0); // palikan leveys
            int blockHeight = block.GetLength(1); // korkeus

            for (int x = 0; x < blockWidth; x++)
            {
                for (int y = 0; y < blockHeight; y++)
                {
                    int boardX = position.X + x;
                    int boardY = position.Y + y;

                    if (block[x, y] == 1)
                    {                        
                        if (boardX < 0 || boardX >= BoardWidth || boardY >= BoardHeight)
                        {
                            return false;
                        }
                        if (boardY >= 0 && board[boardX, boardY])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void MergeBlock()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (currentBlock[x, y] == 1)
                    {
                        int boardX = currentBlockPosition.X + x;
                        int boardY = currentBlockPosition.Y + y;

                        if (boardX >= 0 && boardX < BoardWidth && boardY >= 0 && boardY < BoardHeight)
                        {
                            board[boardX, boardY] = true;
                        }
                        else { }
                    }
                }
            }
        }

        private void CheckForLines()
        {
            for (int y = BoardHeight - 1; y >= 0; y--)
            {
                bool isLineFull = true;
                for (int x = 0; x < BoardWidth; x++)
                {
                    if (!board[x, y])
                    {
                        isLineFull = false;
                        break;
                    }
                }
                if (isLineFull)
                {
                    RemoveLine(y);
                    y++;
                }
            }
        }

        private void RemoveLine(int line)
        {
            for (int y = line; y > 0; y--)
            {
                for (int x = 0; x < BoardWidth; x++)
                {
                    board[x, y] = board[x, y - 1];
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int blockSize = 25;

            // Draw the board
            for (int x = 0; x < BoardWidth; x++)
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    if (board[x, y])
                    {
                        // laske tetron sijainti ja koko
                        int xPos = x * blockSize;
                        int yPos = y * blockSize;
                        Rectangle blockRect = new Rectangle(xPos, yPos, blockSize, blockSize);

                        g.FillRectangle(Brushes.Red, blockRect);
                    }
                }
            }

            // Draw the current block
            if (currentBlock != null)
            {
                int blockWidth = currentBlock.GetLength(0);
                int blockHeight = currentBlock.GetLength(1);

                for (int x = 0; x < blockWidth; x++)
                {
                    for (int y = 0; y < blockHeight; y++)
                    {
                        if (currentBlock[x, y] == 1)
                        {
                            int drawX = currentBlockPosition.X + x;
                            int drawY = currentBlockPosition.Y + y;

                            if (drawX >= 0 && drawX < BoardWidth && drawY >= 0 && drawY < BoardHeight)
                            {
                                g.FillRectangle(Brushes.Cyan, (currentBlockPosition.X + x) * BlockSize, (currentBlockPosition.Y + y) * BlockSize, BlockSize, BlockSize);
                            }
                        }
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    MoveBlock(-1, 0);
                    break;
                case Keys.Right:
                    MoveBlock(1, 0);
                    break;
                case Keys.Down:
                    MoveBlock(0, 1);
                    break;
                case Keys.Up:
                    // Rotate block
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

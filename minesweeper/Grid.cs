using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    internal class Grid
    {
        public int[,] MineGrid;
        public char[,] VisGrid;
        public int TotalMoves;
        public int moves = 1;

        public Grid(string[] size, int bombCount)
        {
            MineGrid = new int[int.Parse(size[0]), int.Parse(size[1])];
            VisGrid = new char[int.Parse(size[0]), int.Parse(size[1])];
            TotalMoves = int.Parse(size[0]) * int.Parse(size[1]) - bombCount + 1;

            for (int i = 0; i < MineGrid.GetLength(0); i++)
            {
                for (int j = 0; j < MineGrid.GetLength(1); j++)
                {
                    MineGrid[i, j] = 0;
                    VisGrid[i, j] = 'x';
                }
            }

            for (int i = 0; i < bombCount; i++)
            {
                Random rnd = new Random();

                int rndx = rnd.Next(MineGrid.GetLength(0));
                int rndy = rnd.Next(MineGrid.GetLength(1));

                if (MineGrid[rndx, rndy] != 1)
                {
                    MineGrid[rndx, rndy] = 1;
                }
                else
                {
                    i--;
                }
            }
        }

        public void DisplayGrid()
        {
            for (int i = 0; i < VisGrid.GetLength(0); i++)
            {
                for (int j = 0; j < VisGrid.GetLength(1); j++)
                {
                    Console.Write(VisGrid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int CheckBomb(int x, int y)
        {
            int AdjBomb = 0;

            if (x >= MineGrid.GetLength(0) || x < 0 || y >= MineGrid.GetLength(1) || y < 0)
            {
                return -1;
            }

            if (MineGrid[x, y] == 1)
            {
                return -2;
            } else if (VisGrid[x, y] != 'x')
            {
                return -3;
            }

            if (x + 1 >= MineGrid.GetLength(0))
            {
            }else if (MineGrid[x + 1, y] == 1)
            {
                AdjBomb++;
            }

            if (x - 1 < 0)
            {
            }
            else if (MineGrid[x - 1, y] == 1)
            {
                AdjBomb++;
            }

            if (y + 1 >= MineGrid.GetLength(1))
            {
            }
            else if (MineGrid[x, y + 1] == 1)
            {
                AdjBomb++;
            }

            if (y - 1 < 0)
            {
            }
            else if (MineGrid[x, y - 1] == 1)
            {
                AdjBomb++;
            }

            VisGrid[x, y] = (char)(AdjBomb + 48);

            if (AdjBomb == 0)
            {
                if (x + 1 < MineGrid.GetLength(0) && VisGrid[x + 1, y] == 'x')
                {
                    CheckBomb(x + 1, y);
                }

                if (x - 1 > 0 && VisGrid[x - 1, y] == 'x')
                {
                    CheckBomb(x - 1, y);
                }

                if (y + 1 < MineGrid.GetLength(1) && VisGrid[x, y + 1] == 'x')
                {
                    CheckBomb(x, y + 1);
                }

                if (y - 1 > 0 && VisGrid[x, y - 1] == 'x')
                {
                    CheckBomb(x, y - 1);
                }
            }

            moves++;
            return 0;

        }
    }
}

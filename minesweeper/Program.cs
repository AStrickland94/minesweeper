using System.Text.RegularExpressions;

namespace minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;

            while (play == true)
            {
                Game Game = new Game();

                Game.StartGame();
            };
            

            /*
            Grid MineGrid = new Grid(size, bombCount);

            MineGrid.DisplayGrid();

            while ( MineGrid.moves <= MineGrid.TotalMoves)
            {
                if (MineGrid.moves == MineGrid.TotalMoves)
                {
                    Console.WriteLine("You win!");
                    break;
                }

                Console.WriteLine($"Please enter the coordinate you would like to check using a ','");
                string guess = Console.ReadLine();

                if (!Regex.IsMatch(guess, @"^\d[,]\d$"))
                {
                    Console.WriteLine("Please enter a valid selection");
                    continue;
                }

                int x = int.Parse(guess.Split(',')[0]) - 1;
                int y = int.Parse(guess.Split(',')[1]) - 1;
                int result = MineGrid.CheckBomb(x, y);

                if (result == -1)
                {
                    Console.WriteLine("Selection is out of bounds. Please choose a new one");
                    continue;
                }else if (result == -2)
                {
                    Console.WriteLine("You lose!");
                    break;
                } else if (result == -3)
                {
                    Console.WriteLine("You have already made this selection. Please choose a new one");
                    continue;
                }

                MineGrid.DisplayGrid();
            }
            */
        }
    }
}
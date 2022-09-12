using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace minesweeper
{
    internal class Game
    {
        public string[] size;
        public int bombCount;
        public void StartGame()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Please enter the desired board size with an x");
                string sizeCheck = Console.ReadLine();

                if (!Regex.IsMatch(sizeCheck, @"^\d[x]\d$"))
                {
                    Console.WriteLine("Invalid size");
                    i--;
                }
                else
                {
                    size = sizeCheck.Split('x');
                }
            }

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("How many bombs would you like?");
                string bombCheck = Console.ReadLine();

                if (!Regex.IsMatch(bombCheck, @"^[0-9]{1,2}$") || bombCheck == "0" || int.Parse(bombCheck) > int.Parse(size[0]) * int.Parse(size[1]) - 1)
                {
                    Console.WriteLine("Invalid amount");
                    i--;
                }
                else
                {
                    bombCount = int.Parse(bombCheck);
                }
            }

            Grid MineGrid = new Grid(size, bombCount);
        }

        public void PlayerMove()
        {

        }
    }
}

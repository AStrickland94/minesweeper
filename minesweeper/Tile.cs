using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    internal class Tile
    {
        public bool IsBomb = false;
        public int AdjCount = -1;
    }
}

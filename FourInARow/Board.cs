using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow
{
    class Board
    {
        //Board info
        bool gameOn { get; set; }
        List<Player> players = new List<Player>();
        bool turn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow
{
    //Class that is gonna store the info of the player
    class Player
    {
        public string name { get; set; }
        public int score { get; set; } = 0;

        public List<Piece> piecesPosition = new List<Piece>();
    }
}

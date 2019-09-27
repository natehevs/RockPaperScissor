using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Move
    {
        //memb er variables (Has A)

        public int numberOfMoves;

        //constructor (Spawner)

        public Move()
        {
            numberOfMoves = 5;
            Random rnd = new Random();
            int MoveID = rnd.Next(1, 6);
        }

        public int MoveID { get; internal set; }
        public string MoveName { get; internal set; }

        //member methods (Can Do)

    }
}

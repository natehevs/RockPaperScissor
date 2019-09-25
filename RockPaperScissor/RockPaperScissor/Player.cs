using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Player
    {
        //member variables (Has A)

        public int score;

        //constructor (Spawner)
        
        public Player()
        {
            score = 0;
        }

        //member methods (Can Do)

        public int HandMove(Move move, Random rng)
        {
            int shake = rng.Next(1, move.numberOfMoves + 1);
            return shake;
        }
    }
}

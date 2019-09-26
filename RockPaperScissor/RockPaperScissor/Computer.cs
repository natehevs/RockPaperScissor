using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Computer
    {
        //memb er variables (Has A)



        //constructor (Spawner)

        public int HandMove(Move move, Random rng)
        {
            int shake = rng.Next(1, move.numberOfMoves + 1);
            return shake;
        }

        //member methods (Can Do)
    }
}

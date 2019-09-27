using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Computer: Player
    {
        public override void ChooseMove()
        {
            throw new NotImplementedException();
        }

        public override void ChooseName()
        {
            throw new NotImplementedException();
        }

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

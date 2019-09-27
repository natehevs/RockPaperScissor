using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Human: Player
    {
        //memb er variables (Has A)

        private new string move;

        //constructor (Spawner)

        public override void ChooseMove()
        {
            Console.WriteLine("Choose a move.");
            move = Console.ReadLine();
        }
        public override void ChooseName()
        {

        }

        //member methods (Can Do)
    }
}

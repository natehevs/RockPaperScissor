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

        //constructor (Spawner)

        public override void ChooseMove()
        {
            Console.WriteLine("Please select a move. Rock, Paper, Scissors, Lizard, Spock");
            move = Console.ReadLine();
        }
        public override void ChooseName()
        {

        }

        //member methods (Can Do)
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    abstract class Human
    {
        //memb er variables (Has A)

        string move;

        //constructor (Spawner)

        public override void ChooseMove()
        {
            Console.WriteLine("Choose a move.");
            move = Console.ReadLine();
        }

        //member methods (Can Do)
    }
}

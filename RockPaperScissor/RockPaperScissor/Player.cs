using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    abstract class Player
    {
        //member variables (Has A)

        public int score;
        public string name;
        public string move;
        public abstract void ChooseMove();
        public abstract void ChooseName();

        //constructor (Spawner)
        
        public Player()
        {
            score = 0;
        }

        //member methods (Can Do)

       
    }
}

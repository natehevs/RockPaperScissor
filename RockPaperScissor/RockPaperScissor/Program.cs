using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game rpslsGame = new Game();
            rpslsGame.RunGame();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Game
    {
        //memb er variables (Has A)
        public Player playerOne;
        public Player playerTwo;
        public Move move;
        public Random rng;

        //constructor (Spawner)
        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
            move = new Move();
            rng = new Random();
        }

        //member methods (Can Do)
        public void RunGame()
        {
            DisplayRules();

            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                int playerOneMove = playerOne.HandMove(move, rng);
                int playerTwoMove = playerTwo.HandMove(move, rng);

                playerOne.score += playerOneMove;
                playerTwo.score += playerTwoMove;

                DisplayCurrentScore();
            }

            DisplayGameWinner();

        }
        public void DisplayCurrentScore()
        {
            Console.WriteLine("Current score: " + playerOne.score + "-" + playerTwo.score);
        }

        public void DisplayRules()
        {
            Console.WriteLine("Two players take turns playing Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("First player to 3 points wins!");
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("Player One won the game!");
            }
            else if (playerTwo.score > playerOne.score)
            {
                Console.WriteLine("Player Two won the game!");
            }
            else
            {
                Console.WriteLine("Tie!");
            }
        }
    }
}

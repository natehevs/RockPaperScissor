using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Game
    {
        //1. display rules
        //2. how many players
        //3. get names
        //4. how many rounds
        //5. player chose gesture
        //6. compare gestures
        //7. determine round winner, incriment winner score by 1
        //8. a. check if game winner, if yes congrats and ask to play again
        //   b. if no, repeat for step 5-8
        //memb er variables (Has A)
        public Player playerOne;
        public Player playerTwo;
        public Move move;
        public Random rng;

        //constructor (Spawner)
        public Game()
        {
            playerOne = new Human();
            playerTwo = new Computer();
            move = new Move();
            rng = new Random();
        }

        //member methods (Can Do)
        public void RunGame()
        {
            int numberOfPlayers = GetNumberOfPlayers();
            CreatePlayers(numberOfPlayers);
            playerOne.ChooseMove();
            playerTwo.ChooseMove();
        }

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players are competing?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void CreatePlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if(numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                playerOne = new Computer();
                playerTwo = new Computer();
            }
        }

        public void DisplayCurrentScore()
        {
            Console.WriteLine("Current score: " + playerOne.score + "-" + playerTwo.score);
        }

        public void DisplayRules()
        {
            Console.WriteLine("Two players take turns playing Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("First player to 2 wins wins the game!");
        }

        public void DisplayHandMoveOptions()
        {
            Console.WriteLine("Please select a move. 1=Rock, 2=Paper, 3=Scissors, 4=Lizard, 5=Spock");
        }

        public void DisplayHandMove()
        {
            IList<Move> MoveList = new List<Move>() {
                new Move(){ MoveID=1, MoveName="Rock"},
                new Move(){ MoveID=2, MoveName="Paper"},
                new Move(){ MoveID=3, MoveName="Scissors"},
                new Move(){ MoveID=4, MoveName="Lizard"},
                new Move(){ MoveID=5, MoveName="Spock"},
            };
        }

        public void DisplayGameWinner()
        {
            Console.ReadLine();
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

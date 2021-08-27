using System;
using System.Collections.Generic;
using System.Text;

// This class's main role is to start the game, determine the winner and end the game
namespace RPSLS_Two
{
    public class TheGame
    {
        // where parts of the game are tracked
        public bool gameStatus;
        public object PlayerOne;    // must be a human player
        public object PlayerTwo;    // second human player if needed
        public object Computer;     // computer player if needed
        public int playerOneScore;  // the current score for each player
        public int playerTwoScore;
        public int winningScore;    // number of rounds required to win the  game
        public string Gamewinner;   // winner of 2 rounds
        public string numberofHumanPlayers; // how many human players in game

        // constructor to start game
        public TheGame()
        {
            gameStatus = true;
            playerOneScore = 0;
            playerTwoScore = 0;
            winningScore = 2;

            // get the number of human players
            NumberOfPlayers();

            // create the players based on number of human players
            CreatePlayers();

            // create move lists (RPSLS)
            CreateMoveList();

            // start actual RPSLS game and continue until there is winner
            //StartRpsls();
        }

        // method to get the number of players and validate user input
        public void NumberOfPlayers()
        {
            string userInput = "";

            // prompt user for number of players until they enter 1 or 2
            while (userInput != "1" && userInput != "2")
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Type '1' for a SinglePlayer game");
                Console.WriteLine("Type '2' for a Multi-Player game");
                userInput = Console.ReadLine();
            }

            // store number of human players
            this.numberofHumanPlayers = userInput;
        }

        // method to create players for the game
        public void CreatePlayers()
        {
            HumanPlayer PlayerOne;
            HumanPlayer PlayerTwo;
            ComputerPlayer Computer;

            if (numberofHumanPlayers == "1")
            {
                PlayerOne = new HumanPlayer("Player One");
                Computer = new ComputerPlayer();
            }
            else if (numberofHumanPlayers == "2")
            {
                PlayerOne = new HumanPlayer("Player One");
                PlayerTwo = new HumanPlayer("Player Two");
            }
        }

        // method to create move list (RPSLS)
        public void CreateMoveList()
        {
            // Create list of options for RSPLS
            List<Selection> Options = new List<Selection>();
            Options.Add(new Selection("rock"));
            Options.Add(new Selection("paper"));
            Options.Add(new Selection("scissors"));
            Options.Add(new Selection("lizard"));
            Options.Add(new Selection("spock"));
        }

        // method to start actual RPSLS game
        //public void StartRpsls()
        //{
            
        //    if (numberofHumanPlayers == "1")
        //    {
        //        HumanPlayerOne.PlayerMoveSelection(Console.ReadLine());
        //    }
        //}

        // compare players moves to see who won the round and tally up the score
        public void DetermineRoundWinner(string playerOneName, string playerOneMove, string playerTwoName, string playerTwoMove)
        {
            switch (playerOneMove)
            {
                case "rock":
                    if (playerTwoMove == "rock")
                    {
                        Console.WriteLine("TIE!  Play again!");
                    }
                    else if (playerTwoMove == "scissors" || playerTwoMove == "lizard")
                    {
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.playerTwoScore += 1;
                        Console.WriteLine(playerTwoName + "WINS the round!");
                    }
                    break;
                case "scissors":
                    if (playerTwoMove == "scissors")
                    {
                        Console.WriteLine("TIE!  Play again!");
                    }
                    else if (playerTwoMove == "paper" || playerTwoMove == "lizard")
                    {
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.playerTwoScore += 1;
                        Console.WriteLine(playerTwoName + "WINS the round!");
                    }
                    break;
                case "paper":
                    if (playerTwoMove == "paper")
                    {
                        Console.WriteLine("TIE!  Play again!");
                    }
                    else if (playerTwoMove == "rock" || playerTwoMove == "spock")
                    {
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.playerTwoScore += 1;
                        Console.WriteLine(playerTwoName + "WINS the round!");
                    }
                    break;
                case "lizard":
                    if (playerTwoMove == "lizard")
                    {
                        Console.WriteLine("TIE!  Play again!");
                    }
                    else if (playerTwoMove == "spock" || playerTwoMove == "paper")
                    {
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.playerTwoScore += 1;
                        Console.WriteLine(playerTwoName + "WINS the round!");
                    }
                    break;
                case "spock":
                    if (playerTwoMove == "spock")
                    {
                        Console.WriteLine("TIE!  Play again!");
                    }
                    else if (playerTwoMove == "scissors" || playerTwoMove == "rock")
                    {
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.playerTwoScore += 1;
                        Console.WriteLine(playerTwoName + "WINS the round!");
                    }
                    break;
                default:
                    break;
            }
        }

        // this method display message that the game is over
        public void EndGame()
        {
            gameStatus = false;
            Console.Write("Game Over!");
        }
    }
}

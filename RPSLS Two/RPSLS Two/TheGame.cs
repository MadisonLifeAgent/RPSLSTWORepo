using System;
using System.Collections.Generic;
using System.Text;

// This class's main role is to start the game, determine the winner and end the game
namespace RPSLS_Two
{
    public class TheGame
    {
        // where parts of the game are tracked
        public string numberOfHumanPlayers;
        public List<Selection> Options;
        public int playerOneScore;
        public int playerTwoScore;

        // constructor to start game and play it
        public TheGame()
        {
            // Intro Message
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock!\n" +
                "---------------------------------------------------\n" +
                "How many Human Players?\n");

            // Get number of human players
            while (numberOfHumanPlayers != "1" && numberOfHumanPlayers != "2")
            {
                Console.WriteLine("Enter '1' or '2' Only:  ");
                numberOfHumanPlayers = Console.ReadLine();
            }

            // set scores to value of 0 
            playerOneScore = 0;
            playerTwoScore = 0;

            // Create Moves list for RSPLS
            this.Options = new List<Selection>();
            Options.Add(new Selection("rock"));
            Options.Add(new Selection("paper"));
            Options.Add(new Selection("scissors"));
            Options.Add(new Selection("lizard"));
            Options.Add(new Selection("spock"));

            // create players
            HumanPlayer HumanPlayerOne = new HumanPlayer("Player One");
            HumanPlayer HumanPlayerTwo = new HumanPlayer("PlayerTwo");
            ComputerPlayer Computer = new ComputerPlayer();

            // while there is no game winner keep getting move selection from player(s)
            while (playerOneScore < 2 && playerTwoScore < 2)
            {
                // display moves and get player moves for a human versus computer game
                if (numberOfHumanPlayers == "1")
                {
                    // get human player's move
                    HumanPlayerOne.MoveSelection(Options, HumanPlayerOne.playerName);

                    // get a random number between 0 and length of move list
                    GenerateRandomNumber RandomNumber = new GenerateRandomNumber(Options.Count);

                    // get move for computer based on random number generated
                    Computer.ComputerMoveSelection(Options[RandomNumber.moveListIndex].move);
                    Console.WriteLine("Computer's Move:  " + Computer.move);

                    // compare moves and determine winner
                    DetermineRoundWinner(HumanPlayerOne.playerName, HumanPlayerOne.move, Computer.playerName, Computer.move);

                    // display current score
                    Console.WriteLine("\n----------SCOREBOARD----------\n"
                        + "Player One:  " + playerOneScore + "\n"
                        + "Player Two:  " + playerTwoScore + "\n"
                        + "------------------------------");
                }
                // display moves and get player moves for a human versus human game
                else if (numberOfHumanPlayers == "2")
                {
                    // Get Player One Move
                    HumanPlayerOne.MoveSelection(Options, HumanPlayerOne.playerName);

                    // Get Player Two Move
                    HumanPlayerTwo.MoveSelection(Options, HumanPlayerTwo.playerName);

                    // Compare moves and determine winner
                    DetermineRoundWinner(HumanPlayerOne.playerName, HumanPlayerOne.move, HumanPlayerTwo.playerName, HumanPlayerTwo.move);

                    // display current moves and score
                    Console.WriteLine("Player One Move:  " + HumanPlayerOne.move +
                        "\nPlayer Two Move:  " + HumanPlayerTwo.move);

                    Console.WriteLine("\n----------SCOREBOARD----------\n"
                        + "Player One:  " + playerOneScore + "\n"
                        + "Player Two:  " + playerTwoScore + "\n"
                        + "------------------------------");
                }
            }

            // display the winner
            if (playerOneScore == 2)
            {
                Console.WriteLine("\nPlayer One Wins the Game!!! 8) \nGame Over");
            }
            else if (playerTwoScore == 2)
            {
                Console.WriteLine("\nPlayer Two / Computer Wins the Game!!! 8( \nGame Over!");
            }
        }

        // compare players moves to see who won the round and tally up the score
        public void DetermineRoundWinner(string playerOneName, string playerOneMove, string playerTwoName, string playerTwoMove)
        {
            {
                switch (playerOneMove)
                {
                    case "rock":
                        if (playerTwoMove == "rock")
                        {
                            Console.WriteLine("\nTIE!  Play again!");
                            break;
                        }
                        else if (playerTwoMove == "scissors" || playerTwoMove == "lizard")
                        {
                            this.playerOneScore += 1;
                            Console.WriteLine("\n" + playerOneName + " WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + " WINS the round!");
                            break;
                        }
                    case "scissors":
                        if (playerTwoMove == "scissors")
                        {
                            Console.WriteLine("\n TIE!  Play again!");
                            break;
                        }
                        else if (playerTwoMove == "paper" || playerTwoMove == "lizard")
                        {
                            this.playerOneScore += 1;
                            Console.WriteLine("\n" + playerOneName + " WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + " WINS the round!");
                            break;
                        }
                    case "paper":
                        if (playerTwoMove == "paper")
                        {
                            Console.WriteLine("\n TIE!  Play again!");
                            break;
                        }
                        else if (playerTwoMove == "rock" || playerTwoMove == "spock")
                        {
                            this.playerOneScore += 1;
                            Console.WriteLine("\n" + playerOneName + " WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + " WINS the round!");
                            break;
                        }
                    case "lizard":
                        if (playerTwoMove == "lizard")
                        {
                            Console.WriteLine("\n TIE !  Play again!");
                            break;
                        }
                        else if (playerTwoMove == "spock" || playerTwoMove == "paper")
                        {
                            this.playerOneScore += 1;
                            Console.WriteLine("\n" + playerOneName + " WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + " WINS the round!");
                            break;
                        }
                    case "spock":
                        if (playerTwoMove == "spock")
                        {
                            Console.WriteLine("\n TIE !  Play again!");
                            break;
                        }
                        else if (playerTwoMove == "scissors" || playerTwoMove == "rock")
                        {
                            this.playerOneScore += 1;
                            Console.WriteLine("\n" + playerOneName + " WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + " WINS the round!");
                            break;
                        }
                    default:
                        break;
                }
            }
        }

    }
}

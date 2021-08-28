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
            HumanPlayer HumanPlayerOne = new HumanPlayer("PlayerOne");
            HumanPlayer HumanPlayerTwo = new HumanPlayer("PlayerTwo");
            ComputerPlayer Computer = new ComputerPlayer();

            // while there is no game winner keep getting move selection from player(s)
            while (playerOneScore < 2 && playerTwoScore < 2)
            {
                // display moves and get player moves
                if (numberOfHumanPlayers == "1")
                {
                    //display move options
                    Console.WriteLine("\nPlayer One, please select your move from the following options:");
                    foreach (Selection move in Options)
                    {
                        Console.WriteLine("-  " + move.move);
                    }
                        Console.WriteLine("\n");

                    // get human player move
                    HumanPlayerOne.MoveSelection(Console.ReadLine());

                    // get a random number between 0 and length of move list
                    GenerateRandomNumber RandomNumber = new GenerateRandomNumber(Options.Count);

                    // get move for computer based on random number generated
                    Computer.ComputerMoveSelection(Options[RandomNumber.moveListIndex].move);

                    // compare moves and determine winner
                    DetermineRoundWinner(HumanPlayerOne.playerName, HumanPlayerOne.move, Computer.playerName, Computer.move);

                    // display current score
                    Console.WriteLine("\n----------SCOREBOARD----------\n"
                        + "Player One:  " + playerOneScore + "\n"
                        + "Player Two:  " + playerTwoScore + "\n"
                        + "------------------------------");
                }
                Console.WriteLine("c:  " + Computer.move);
            }

            // display the winner
            if (playerOneScore == 2)
            {
                Console.WriteLine("\n" + HumanPlayerOne.playerName + " Wins the Game!!! 8) \nGame Over");
            }
            else if (playerTwoScore == 2)
            {
                Console.WriteLine("\n" + Computer.playerName + " Wins the Game!!! 8( \nGame Over!");
            }

            else if (numberOfHumanPlayers == "2")
            {
                //display move options
                Console.WriteLine("Human Players, please select your move from the following options:");
                foreach (Selection move in Options)
                {
                    Console.WriteLine("-  " + move.move);
                }
                Console.WriteLine("\n");

                // get human player moves
                Console.WriteLine("Player One:  ");
                HumanPlayerOne.MoveSelection(Console.ReadLine());

                Console.WriteLine("Player Two:  ");
                HumanPlayerTwo.MoveSelection(Console.ReadLine());
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
                            Console.WriteLine("\n" + playerOneName + "WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + "WINS the round!");
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
                            Console.WriteLine("\n" + playerOneName + "WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + "WINS the round!");
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
                            Console.WriteLine("\n" + playerOneName + "WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + "WINS the round!");
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
                            Console.WriteLine("\n" + playerOneName + "WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + "WINS the round!");
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
                            Console.WriteLine("\n" + playerOneName + "WINS the round!");
                            break;
                        }
                        else
                        {
                            this.playerTwoScore += 1;
                            Console.WriteLine("\n" + playerTwoName + "WINS the round!");
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        // this method display message that the game is over
        public void EndGame()
        {
            Console.WriteLine("Thanks for playing RPSLS, Goodbye!");
        }
    }
}

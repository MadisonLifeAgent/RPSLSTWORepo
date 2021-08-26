using System;
using System.Collections.Generic;
using System.Text;

// This class's main role is to start, determine the winner and end the game
namespace RPSLS_Two
{
    public class TheGame
    {
        // where each part of the game is tracked
        public bool gameStatus;
        public int playerOneScore;
        public int playerTwoScore;
        public int winningScore;
        public string roundWinner; // winner of a single round
        public string Gamewinner; // winner of 2 rounds

        // constructor to start game
        public TheGame()
        {
            gameStatus = true;
            playerOneScore = 0;
            playerTwoScore = 0;
            winningScore = 2;
        }

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
                        this.roundWinner = playerOneName;
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.roundWinner = playerTwoName;
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
                        this.roundWinner = playerOneName;
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.roundWinner = playerTwoName;
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
                        this.roundWinner = playerOneName;
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.roundWinner = playerTwoName;
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
                        this.roundWinner = playerOneName;
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.roundWinner = playerTwoName;
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
                        this.roundWinner = playerOneName;
                        this.playerOneScore += 1;
                        Console.WriteLine(playerOneName + "WINS the round!");
                    }
                    else
                    {
                        this.roundWinner = playerTwoName;
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

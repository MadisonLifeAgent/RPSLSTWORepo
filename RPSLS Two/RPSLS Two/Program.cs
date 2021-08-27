using System;
using System.Collections.Generic;

namespace RPSLS_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // start the actual game
            TheGame NewGame = new TheGame();

            // Display moves
            //Console.WriteLine("Player One, please select your move from the following options:");
            //foreach (Selection move in Options)
            //{
            //    Console.WriteLine("-  " + move.move);
            //}

            // get move from player one
            //HumanPlayerOne.PlayerMoveSelection(Console.ReadLine());

            // Gnerate a random number which determines the move for the computer
            //GenerateRandomNumber RandomNumber = new GenerateRandomNumber(Options.Count);

            // get the actual move from the list of moves and set it into the computer's player object (this needs to be stored so we can compare it to the human player's move)
            //Computer.ComputerMoveSelection(Options[RandomNumber.moveListIndex].move);

            //  in the NewGame Object compare moves to see who won the round
            //NewGame.DetermineRoundWinner(HumanPlayerOne.playerName, HumanPlayerOne.move, Computer.playerName, Computer.move);


            //Debug lines only
            Console.WriteLine("Player One Score: " + NewGame.playerOneScore);
            //Console.WriteLine("Computer Move: " + Computer.move);
            Console.WriteLine("Computer Score: " + NewGame.playerTwoScore);

            Console.ReadLine();
        }
    }
}

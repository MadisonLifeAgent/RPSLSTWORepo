using System;
using System.Collections.Generic;

namespace RPSLS_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the game by asking for the number of players and validate user input
            Console.WriteLine("Type '1' for a SinglePlayer game");
            Console.WriteLine("Type '2' for a Multi-Player game");
            NumberOfPlayers NewNumberOfPlayers = new NumberOfPlayers(Console.ReadLine());

            //create human players
            CreateHumanPlayer HumanPlayerOne = new CreateHumanPlayer("Player One");
            CreateHumanPlayer HumanPlayerTwo = new CreateHumanPlayer("Player Two");

            //create computer player
            CreateComputerPlayer ComputerPlayer = new CreateComputerPlayer();

            //Debug line only
            Console.WriteLine("The Number of Human Players is: " + NewNumberOfPlayers.userInput);
            Console.WriteLine("Player One's Name is: " + HumanPlayerOne.playerName);
            Console.WriteLine("Player Two's Name is: " + HumanPlayerTwo.playerName);
            Console.WriteLine("Computer Player's Name is: " + ComputerPlayer.playerName);
            Console.ReadLine();


            // Create list of options for RSPLS
/*            List <Option> Options = new List<Option>();
                Options.Add(new Option("rock"));
                Options.Add(new Option("paper"));
                Options.Add(new Option("scissors"));
                Options.Add(new Option("lizard"));
                Options.Add(new Option("spock"));*/


        }
    }
}

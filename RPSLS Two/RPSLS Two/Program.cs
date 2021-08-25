using System;
using System.Collections.Generic;

namespace RPSLS_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // start the game
            Game NewGame = new Game("", "");

            // create the players
            HumanPlayer PlayerOne = new HumanPlayer("Player One");
            HumanPlayer PlayerTwo = new HumanPlayer("Player Two");
            ComputerPlayer ComputerPlayer = new ComputerPlayer("Computer Player");


            // Create list of options for RSPLS
            List <Option> Options = new List<Option>();
                Options.Add(new Option("rock"));
                Options.Add(new Option("paper"));
                Options.Add(new Option("scissors"));
                Options.Add(new Option("lizard"));
                Options.Add(new Option("spock"));

            // ask for the number of human players
            Console.WriteLine("Type 'one' to play against the CPU or 'two' to play against a friend");
            NewGame.GetNumberOfHumanPlayers(Console.ReadLine());

            // get player selections            
        }
    }
}

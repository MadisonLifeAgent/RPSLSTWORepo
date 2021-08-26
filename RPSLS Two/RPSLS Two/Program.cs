﻿using System;
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
            HumanPlayer HumanPlayerOne = new HumanPlayer("Player One");
            HumanPlayer HumanPlayerTwo = new HumanPlayer("Player Two");

            //create computer player
            ComputerPlayer ComputerPlayer = new ComputerPlayer();

            // Create list of options for RSPLS
            List<Selection> Options = new List<Selection>();
            Options.Add(new Selection("rock"));
            Options.Add(new Selection("paper"));
            Options.Add(new Selection("scissors"));
            Options.Add(new Selection("lizard"));
            Options.Add(new Selection("spock"));

            // start the actual game
            TheGame NewGame = new TheGame(HumanPlayerOne.wins, ComputerPlayer.wins);

            // Display moves and get move from player one
            Console.WriteLine("Player One, please select your move from the following options:");
            foreach (Selection move in Options)
            {
                Console.WriteLine("-  " + move.move);
            }
            HumanPlayerOne.PlayerMoveSelection(Console.ReadLine());

            //Debug line only
            Console.WriteLine("This is a list item: " + Options[4].move);
            Console.WriteLine("Human move: " + HumanPlayerOne.selection);
            Console.ReadLine();
        }
    }
}

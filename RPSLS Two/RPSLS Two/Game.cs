using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class Game
    {
        // start the game
        public bool startGame;

        // public int numberOfComputerPlayers;
        public string winner;
        public string loser;

        //constructor to start game
        public Game(string winner, string loser)
        {
            this.winner = winner;
            this.loser = loser;

            startGame = true;
        }

        // this method stores the number of human players which will help determine which types of players to instantiate
        public void GetNumberOfHumanPlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "one")
            {
                Console.WriteLine("One Player Game");
            }
            else if (numberOfPlayers == "two")
            {
                Console.WriteLine("Two Player Game");
            }
            else
            {
                Console.WriteLine("INVALID INPUT HUMAN! - Again, type 'one' (lowercased) to play against the CPU or 'two' (lowercased) to play against a friend");
                GetNumberOfHumanPlayers(Console.ReadLine());
            }
        }

        

    }
}

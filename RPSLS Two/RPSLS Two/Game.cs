using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class Game
    {
        // Store the number of players in each game
        public bool startGame;
        public int numberOfHumanPlayers;
        // public int numberOfComputerPlayers;
        public string winner;
        public string loser;

        //constructor to start game
        public Game(int numberOfHumanPlayers, string winner, string loser)
        {
            this.numberOfHumanPlayers = numberOfHumanPlayers;
            this.winner = winner;
            this.loser = loser;
            
            startGame = true;
        }

        // this method stores the number of human players which will help determine which types of players to instantiate
        public void GetNumberOfHumanPlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "one")
            {
                numberOfHumanPlayers = 1;
            }
            else if (numberOfPlayers == "two")
            {
                numberOfHumanPlayers = 2;
            }
            else
            {
                Console.WriteLine("Type 'one' to play against the CPU or 'two' to play against a friend");
                GetNumberOfHumanPlayers(Console.ReadLine());
            }
        }
    }
}

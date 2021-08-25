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
        public bool playerOneIsHuman;
        public bool playerTwoIsHuman;

        //constructor to start game
        public Game(int numberOfHumanPlayers, string winner, string loser)
        {
            this.numberOfHumanPlayers = numberOfHumanPlayers;
            this.winner = winner;
            this.loser = loser;

            playerOneIsHuman = false;
            playerTwoIsHuman = false;
            startGame = true;
        }

        // this method stores the number of human players which will help determine which types of players to instantiate
        public void GetNumberOfHumanPlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "one")
            {
                numberOfHumanPlayers = 1;
                playerOneIsHuman = true;
                playerTwoIsHuman = false;
            }
            else if (numberOfPlayers == "two")
            {
                numberOfHumanPlayers = 2;
                playerOneIsHuman = true;
                playerTwoIsHuman = true;
            }
            else
            {
                Console.WriteLine("INVALID INPUT HUMAN! - Again, type 'one' (lowercased) to play against the CPU or 'two' (lowercased) to play against a friend");
                GetNumberOfHumanPlayers(Console.ReadLine());
            }
        }

        // this method gets the types of players needed based on user input
        public void GetPlayers()
        {
            if (playerOneIsHuman == true)
            {
                HumanPlayer PlayerOne = new HumanPlayer()
            }
            else
            {

            }
        }


    }
}

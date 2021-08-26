using System;
using System.Collections.Generic;
using System.Text;

// This class's main role is to start and end the game
namespace RPSLS_Two
{
    public class TheGame
    {
        // where each part of the game is tracked
        public bool gameStatus;
        public int playerOneScore;
        public int playerTwoScore;
        public int winningScore;
        public string winner;

        // constructor to start game
        public TheGame(int playerOneScore, int playerTwoScore)
        {
            gameStatus = true;
            this.playerOneScore = playerOneScore;
            this.playerTwoScore = playerTwoScore;
            winningScore = 2;
        }

        // this method turns the game off
        public void EndGame()
        {
            gameStatus = false;
            Console.Write("Game Over!");
        }
    }
}

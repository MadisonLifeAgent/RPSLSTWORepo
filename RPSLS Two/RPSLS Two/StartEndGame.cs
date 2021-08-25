using System;
using System.Collections.Generic;
using System.Text;

// This class's main role is to start and end the game
namespace RPSLS_Two
{
    public class StartEndGame
    {
        // variable to turn the game on or off
        public bool gameStatus;

        // constructor to start game
        public StartEndGame()
        {
            gameStatus = true;
        }

        // this method turns the game off
        public void turnGameOff()
        {
            gameStatus = false;
        }
    }
}

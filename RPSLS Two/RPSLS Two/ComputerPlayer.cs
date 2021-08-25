using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    // this class inherits from it's parent - Player.cs
    public class ComputerPlayer : Player
    {
        public char selection;

        public ComputerPlayer(string playerName)
        {
            this.playerName = playerName;
            human = false;
            numberOfWins = 0;
        }
    }
}

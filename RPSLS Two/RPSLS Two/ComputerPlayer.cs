using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class ComputerPlayer : Player
    {
        public string playerName;

        public ComputerPlayer()
        {
            playerName = "Computer Player";
            this.human = false;
        }
    }
}
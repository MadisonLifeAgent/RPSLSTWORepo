using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class CreateComputerPlayer : Player
    {
        public string playerName;

        public CreateComputerPlayer()
        {
            playerName = "Computer Player";
            this.human = false;
        }
    }
}
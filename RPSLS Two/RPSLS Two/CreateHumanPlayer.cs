using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class CreateHumanPlayer : Player
    {
        public string playerName;

        public CreateHumanPlayer(string playerName)
        {
            this.playerName = playerName;
            this.human = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class HumanPlayer : Player
    {
        public string playerName;

        public HumanPlayer(string playerName)
        {
            this.playerName = playerName;
            this.human = true;
        }

        public void PlayerMoveSelection(string moveSelected)
        {
            this.selection = moveSelected;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

//this class inherits from Player.cs
namespace RPSLS_Two
{
    public class HumanPlayer : Player
    {
        public string playerName;  // stores player name

        public HumanPlayer(string playerName)
        {
            this.playerName = playerName;
            human = true;
        }

        public void MoveSelection(string moveSelected)
        {
            this.move = moveSelected;
        }

    }
}

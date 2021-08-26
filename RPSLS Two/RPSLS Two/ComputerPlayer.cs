using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class ComputerPlayer : Player
    {
        public string playerName;

        //constructor for instantiation
        public ComputerPlayer()
        {
            playerName = "Computer Player";
            this.human = false;
        }

        // stores computer's move
        public void ComputerMoveSelection(string moveSelected)
        {
            this.move = moveSelected;
        }
    }
}
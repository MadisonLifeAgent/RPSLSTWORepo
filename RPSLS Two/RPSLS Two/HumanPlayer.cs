﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    // this class inherits from it's parent - Player.cs
    public class HumanPlayer : Player
    {
        public char selection;

        public HumanPlayer(string playerName)
        {
            this.playerName = playerName;
            human = true;
            numberOfWins = 0;
        }
    }
}

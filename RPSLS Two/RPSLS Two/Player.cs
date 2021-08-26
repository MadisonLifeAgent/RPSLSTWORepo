using System;
using System.Collections.Generic;
using System.Text;

// this is the parent class for players (human or computer)
namespace RPSLS_Two
{
    public class Player
    {
        public int wins;
        public bool human;
        public string selection;

        public Player()
        {
            selection = "";
            wins = 0;
        }
    }
}

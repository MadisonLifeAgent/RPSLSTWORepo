using System;
using System.Collections.Generic;
using System.Text;

// this is the parent class for players (human or computer)
namespace RPSLS_Two
{
    public class Player
    {
        public bool human;
        public string move; // stores a player's move selections

        public Player()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

// this class instantiates a list of moves each player can use
namespace RPSLS_Two
{
    public class Selection
    {
        // variable to store a move - i.e. rock
        public string move;

        // constructor to instantiate a move
        public Selection(string move)
        {
            this.move = move;
        }
    }
}

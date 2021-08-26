using System;
using System.Collections.Generic;
using System.Text;

// this class creates a random number object which is used to determine the computers move
namespace RPSLS_Two
{
    class GenerateRandomNumber
    {
        public int moveListLength;  // this number is used to help get the random number (it is the length of the RPSLS Selection.cs or Options object list)
        public int moveListIndex;   // this is the random number generated

        // constructs the random number
        public GenerateRandomNumber(int ListLength)
        {
            this.moveListLength = ListLength;
            Random randomNumber = new Random();
            moveListIndex = randomNumber.Next(moveListLength);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    class GenerateRandomNumber
    {
        public int moveListLength;
        public int moveListIndex;

        public GenerateRandomNumber(int ListLength)
        {
            this.moveListLength = ListLength;
            Random randomNumber = new Random();
            moveListIndex = randomNumber.Next(moveListLength);
        }

        public void GetRandomIndexNumber()
        {
            //this.moveListIndex = random.Next(moveListLength);

        }
    }
}

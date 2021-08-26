using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Two
{
    public class NumberOfPlayers
    {
        // variable for number of human players
        public string userInput;

        // this is where number of human players is constructed and validated
        public NumberOfPlayers(string userInput)
        {
            // only store the user input if their selection is 1 or 2, otherwise reprompt
            while (userInput != "1" && userInput != "2")
            {
                Console.WriteLine("INVALID SELECTION! PLEASE TRY AGAIN, HUMAN!");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Type '1' for a SinglePlayer game");
                Console.WriteLine("Type '2' for a Multi-Player game");
                userInput = Console.ReadLine();
            }
            
            this.userInput = userInput;
        }
    }
}

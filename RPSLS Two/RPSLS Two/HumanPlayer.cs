using System;
using System.Collections.Generic;
using System.Linq;
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

        public void MoveSelection(List<Selection> MoveOptions, string PlayerName)
        {
            // display move options and get move from user
            Console.WriteLine("\n" + PlayerName + " Please select your move from the following options:");
            foreach (Selection move in MoveOptions)
            {
                Console.WriteLine("-  " + move.move);
            }
            Console.WriteLine("\nMove:");

            // gets move from user
            string moveSelected = Console.ReadLine();

            // used to validate user input is a valid move
            bool inputValidation = MoveOptions.Exists(m => m.move == moveSelected);

            // keep prompting user if input is invalid
            while (inputValidation == false)
            {
                // display move options and get move from user
                Console.WriteLine("\nInvalid Input, please select your move from the following options:");
                foreach (Selection move in MoveOptions)
                {
                    Console.WriteLine("-  " + move.move);
                }
                Console.WriteLine("\nMove:");

                moveSelected = Console.ReadLine();

                inputValidation = MoveOptions.Exists(m => m.move == moveSelected);
            }
            // store input if it is a valid move
            if (inputValidation == true)
            {
                this.move = moveSelected;
            }
        }
    }
}

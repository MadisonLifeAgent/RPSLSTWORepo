using System;

namespace RPSLS_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // start the game
            Game NewGame = new Game(0, "", "");

            // ask for the number of human players
            Console.WriteLine("Type 'one' to play against the CPU or 'two' to play against a friend");
            NewGame.GetNumberOfHumanPlayers(Console.ReadLine());

            // set player types
            NewGame.GetPlayers();
        }
    }
}

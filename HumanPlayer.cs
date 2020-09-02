using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.Write("Enter a roll: ");
            string answer = Console.ReadLine().ToLower();
            // While answer is not y or n, keep asking AskTheMoose
            while (TestNumber(answer) == false)
            {
                Console.Write("Enter a roll: ");
                answer = Console.ReadLine().ToLower();
            }

            // Call roll for "this" object and for the "other" object
            int myRoll = int.Parse(answer);
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

        static Boolean TestNumber(string testNumberValue)
        {
            return int.TryParse(testNumberValue, out int numberValue);
        }
    }
}
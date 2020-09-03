using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

        public override int Roll()
        {
            string answer = "NaN";

            while (!TestNumber(answer))
            {
                Console.Write("Enter a roll: ");
                answer = Console.ReadLine().ToLower();
            }
            return int.Parse(answer);

        }

        static Boolean TestNumber(string testNumberValue)
        {
            return int.TryParse(testNumberValue, out int numberValue);
        }
    }
}
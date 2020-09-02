using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        private List<string> _tauntCollection { get; } = new List<string>
        {
            "You deserve not only to be given no food to eat, but also to have the dogs set upon you and to be pelted with horse manure.",
            "You are blasphemous, abominable rascals and damned scum of Satan!",
            "We may confidently suppose and be sure that your spirit will produce evidence and proof when the devil becomes God.",
            "You are a coarse devil who hurts me but little.",
            "For you are an excellent person, as skilful, clever, and versed in Holy Scripture as a cow in a walnut tree or a sow on a harp.",
            "You hellish scum.",
            "You are the true print and touch of the devil.",
            "Here now, you ass, with your long donkey ears and accursed liar's mouth!",
            "You pant after the garlic and melons of Egypt and have already long suffered from perverted tastes.",
            "You ought to feel shame in your hearts, you great gruff asses' heads."
        };

        public string Taunt { get; set; }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            Taunt = _tauntCollection.ElementAt(new Random().Next(1, 10));

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine(Taunt);
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

    }
}
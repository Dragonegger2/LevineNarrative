using System;
using System.Collections.Generic;
using LevineNarrative.Blocks;

namespace LevineNarrative
{
    public class Narrative
    {
        public static void Main(string[] args)
        {
            var passionList = new List<IPassion>();
            var david = new BaseStar(passionList);

            david.Name = "David";

            var passionCats = new BasePassion();
            passionCats.PassionValue = 19;
            passionCats.PassionName = "Cats";
            
            passionCats.Threshholds.Add(new BaseThreshhold("Cat-like affinity", "Your burgeoning love for cats has allowed for this bonus to manifest.", 10));
            passionCats.Threshholds.Add(new BaseThreshhold("Cat-like reflexes", "Your burgeoning love for cats has allowed for this bonus to manifest.", 20));
            passionCats.Threshholds.Add(new BaseThreshhold("Dog-like affinity", "Your burgeoning love for dogs has brough this burden on you.", -10));

            foreach(var thresh in passionCats.ThreshholdsHit()) 
            {
                Console.WriteLine(thresh);
            }

            Console.ReadKey();

            david.Passions.Add(passionCats);
        }
    }
}

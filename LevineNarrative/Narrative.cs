using System;
using System.Collections.Generic;
using System.Linq;
using LevineNarrative.Blocks;
using LevineNarrative.System;

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
            passionCats.PassionValue = 10;
            passionCats.PassionName = "Cats";
            
            passionCats.Threshholds.Add(new BaseThreshhold("Cat-like affinity", "Your burgeoning love for cats has allowed for this bonus to manifest.", 10));
            passionCats.Threshholds.Add(new BaseThreshhold("Cat-like reflexes", "Your reflexes are no longer like that of a dead cat. More like a live one. Or something like that.", 20));
            passionCats.Threshholds.Add(new BaseThreshhold("Dog-like affinity", "Your burgeoning love for dogs has brough this burden on you.", -10));

            passionCats.Likes.Add(PassionValue.Cats);
            passionCats.Hates.Add(PassionValue.Dogs);

            david.Passions.Add(passionCats);

            Console.WriteLine("David before event.");
            foreach (var thresh in passionCats.ThreshholdsHit())
            {
                Console.WriteLine(thresh);
            }

            var actionListener = new ActionListener();

            actionListener.ManagedPassions.Add(david.Passions.First());
            actionListener.FireEvent(PassionValue.Dogs, 10);

            Console.WriteLine("David after event.");
            foreach(var thresh in passionCats.ThreshholdsHit()) 
            {
                Console.WriteLine(thresh);
            }

            Console.ReadKey();

        }
    }
}

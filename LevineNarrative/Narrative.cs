using System;
using System.Collections.Generic;
using System.Linq;
using LevineNarrative.Blocks;
using LevineNarrative.BuildingBlocks;
using LevineNarrative.System;

namespace LevineNarrative
{
    public class Narrative
    {
        public static void Main(string[] args)
        {
            //passionsTest();
            villageTest();
        }

        private static void passionsTest()
        {
            var passionList = new List<IPassion>();
            var david = new BaseStar(passionList, "David");

            var passionCats = new BasePassion();
            passionCats.PassionValue = 10;
            passionCats.PassionName = "Cats";

            passionCats.Thresholds.Add(new BaseThreshold("Cat-like affinity", "Your burgeoning love for cats has allowed for this bonus to manifest.", 10));
            passionCats.Thresholds.Add(new BaseThreshold("Cat-like reflexes", "Your reflexes are no longer like that of a dead cat. More like a live one. Or something like that.", 20));
            passionCats.Thresholds.Add(new BaseThreshold("Dog-like affinity", "Your burgeoning love for dogs has brough this burden on you.", -10));

            passionCats.Likes.Add(PassionValue.Cats);
            passionCats.Hates.Add(PassionValue.Dogs);

            david.Passions.Add(passionCats);

            Console.WriteLine("David before event.");
            foreach (var thresh in passionCats.ThresholdsHit())
            {
                Console.WriteLine(thresh);
            }

            var actionListener = new ActionListener();

            actionListener.ManagedPassions.Add(david.Passions.First());
            actionListener.FireEvent(PassionValue.Dogs, 10);

            Console.WriteLine("David after event.");
            foreach (var thresh in passionCats.ThresholdsHit())
            {
                Console.WriteLine(thresh);
            }

            Console.ReadKey();

        }

        private static void villageTest()
        {
            BaseVillage testVillage = new BaseVillage();
            testVillage.VillageName = "Test Town";

            List<IStar> stars = new List<IStar>();

            var david = new BaseStar();

            david.Name = "David";

            // Create some passions for testing
            var passionCats = new BasePassion();
            passionCats.PassionValue = 10;
            passionCats.PassionName = "Cats";

            passionCats.Thresholds.Add(new BaseThreshold("Cat-like affinity", "Your burgeoning love for cats has allowed for this bonus to manifest.", 10));
            passionCats.Thresholds.Add(new BaseThreshold("Cat-like reflexes", "Your reflexes are no longer like that of a dead cat. More like a live one. Or something like that.", 20));
            passionCats.Thresholds.Add(new BaseThreshold("Dog-like affinity", "Your burgeoning love for dogs has brough this burden on you.", -10));

            passionCats.Likes.Add(PassionValue.Cats);
            passionCats.Hates.Add(PassionValue.Dogs);

            david.Passions.Add(passionCats);

            //-------------------------------untested----------------------------------------------------//
            var trent = new BaseStar();
            trent.Name = "Trent";

            var passionNoodles = new BasePassion();
            passionNoodles.PassionName = "Noodles";
            passionNoodles.PassionValue = 15;

            passionNoodles.Thresholds.Add(new BaseThreshold("Noodle liker", "Your love of noodles is beginning to become hard to contain", 10));
            passionNoodles.Thresholds.Add(new BaseThreshold("Noodle connoisseur", "Only the greatest of noodles can satiate your tastes", 50));
            passionNoodles.Thresholds.Add(new BaseThreshold("Rice lover", "Not a sex thing... probably", -25));

            trent.Passions.Add(passionNoodles);

            var testBoy = new BaseStar();
            testBoy.Name = "Testy";

            var passionTest = new BasePassion();
            passionTest.PassionName = "Testing";
            passionTest.PassionValue = 10;

            passionTest.Thresholds.Add(new BaseThreshold("Testing affinity", "You can test like a tester", 5));
            passionTest.Thresholds.Add(new BaseThreshold("Testing Mastery", "Testing with the best of them", 50));

            testBoy.Passions.Add(passionTest);

            // actual village testing

            // PassionManager seems like a good name?
            var passionManager = new ActionListener();
            passionManager.ManagedPassions.Add(passionCats);
            passionManager.ManagedPassions.Add(passionNoodles);
            passionManager.ManagedPassions.Add(passionTest);

            // Add the stars, and shoot for them  <----- Who the hell commented this code? -Willem
            testVillage.Stars.Add(trent);
            testVillage.Stars.Add(david);
            testVillage.Stars.Add(testBoy);

            Console.WriteLine("Village setup complete");

            Console.WriteLine("Village before testing");
            Console.WriteLine(testVillage.ToString());

            // Now do some stuff to the stars.
            passionManager.FireEvent(PassionValue.Cats, 20);
            passionManager.FireEvent(PassionValue.Cats, 30);
            passionManager.FireEvent(PassionValue.Noodles, 40);

            Console.WriteLine("Village after testing");
            Console.WriteLine(testVillage);

            Console.ReadLine();
        }
    }
}

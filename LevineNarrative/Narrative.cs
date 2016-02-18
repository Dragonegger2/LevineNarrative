using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LevineNarrative.Blocks;
using LevineNarrative.System;
using Newtonsoft.Json;

namespace LevineNarrative
{
    public class Narrative
    {
        public static void Main(string[] args)
        {
            var passionList = new List<IPassion>();
            var trump = new BaseStar(passionList);

            trump.Name = "Trump";

            var passionCats = new BasePassion();
            passionCats.PassionValue = 10;
            passionCats.PassionName = "Cat Afficianado";
            
            passionCats.Thresholds.Add(new BaseThreshold("Cat-like affinity", "Your burgeoning love for cats has allowed for this bonus to manifest.", 10));
            passionCats.Thresholds.Add(new BaseThreshold("Cat-like reflexes", "Your reflexes are no longer like that of a dead cat. More like a live one. Or something like that.", 20));
            passionCats.Thresholds.Add(new BaseThreshold("Dog-like affinity", "Your burgeoning love for dogs has brough this burden on you.", -10));

            passionCats.Likes.Add("Elves");
            passionCats.Hates.Add("Brown");

            trump.Passions.Add(passionCats);

            var jsonOutput = JsonConvert.SerializeObject(trump);
            File.WriteAllText("trump.json", jsonOutput);
        }
    }
}

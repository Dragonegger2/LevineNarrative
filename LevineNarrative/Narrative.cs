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


        }
    }
}

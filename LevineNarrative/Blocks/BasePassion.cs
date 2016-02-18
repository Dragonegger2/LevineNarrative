using LevineNarrative.BuildingBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative.Blocks
{
    public class BasePassion : IPassion
    {
        public BasePassion()
        {
            Thresholds = new List<IThreshold>();
            Likes = new List<string>();
            Hates = new List<string>();
        }
        public string PassionName { get; set; }

        //Floating passion value.
        public float PassionValue { get; set; }

        public List<string> Likes { get; set; }
        public List<string> Hates { get; set; }

        public List<IThreshold> Thresholds { get; set; }

        public List<IThreshold> ThresholdsHit()
        {
            var threshholds = Thresholds.FindAll(i => i.Value < 0 && i.Value >= PassionValue);
            threshholds.AddRange(Thresholds.FindAll(i => i.Value > 0 && i.Value <= PassionValue));
            return threshholds;
        }

        public override string ToString()
        {
            var locator = "-100 <----------------------------------------> 100 Current: ";
            var center = 26;
            return PassionName + "\n" + locator.Insert((int)(Math.Floor(PassionValue / 5)) + center, "|") + " " + PassionValue + "\n";
        }
    }
}

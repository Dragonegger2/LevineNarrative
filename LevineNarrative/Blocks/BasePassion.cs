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
            Threshholds = new List<IThreshhold>();
            Likes = new List<PassionValue>();
            Hates = new List<PassionValue>();
        }
        public string PassionName { get; set; }

        //Floating passion value.
        public float PassionValue { get; set; }

        public List<PassionValue> Likes { get; set; }
        public List<PassionValue> Hates { get; set; }

        public List<IThreshhold> Threshholds { get; set; }

        public List<IThreshhold> ThreshholdsHit()
        {
            var threshholds = Threshholds.FindAll(i => i.Value < 0 && i.Value >= PassionValue);
            threshholds.AddRange(Threshholds.FindAll(i => i.Value > 0 && i.Value <= PassionValue));
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

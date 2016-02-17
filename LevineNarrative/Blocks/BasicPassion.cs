using LevineNarrative.BuildingBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative.Blocks
{
    public class BasicPassion : IPassion
    {

        public string PassionName { get; set; }

        //Floating passion value.
        public float PassionValue { get; set; }

        public List<IThreshhold> Threshholds { get; set; }

        public List<IThreshhold> ThreshholdsHit()
        {
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LevineNarrative.BuildingBlocks;

namespace LevineNarrative.Blocks
{
    public class BaseThreshhold : IThreshhold
    {
        public BaseThreshhold(string name, string desc, int val)
        {
            Name = name;
            Description = desc;
            Value = val;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\n"
                   + "Description: " + Description + "\n"
                   + "Value: " + Value + "\n\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative.BuildingBlocks
{
    public interface IThreshhold
    {
        string Name { get; set; }
        string Description {get; set;}
        int Value { get; set; }
    }
}

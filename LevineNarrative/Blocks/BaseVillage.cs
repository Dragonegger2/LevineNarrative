
using System.Collections.Generic;
using LevineNarrative.BuildingBlocks;

namespace LevineNarrative.Blocks
{
    public class BaseVillage : IVillage
    {
        public string VillageName { get; set; }
        public List<IStar> Stars { get; set; }

        public int MacroPassion 
        {
            get { return 0; }
        }
    }
}

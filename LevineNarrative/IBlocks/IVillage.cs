using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative.BuildingBlocks
{
    public interface IVillage
    {
        string VillageName { get; set; }
        List<IStar> Stars { get; set; }
        int MacroPassion { get; }
        List<IThreshold> VillageThreshold { get; set; }
    }
}

using System.Collections.Generic;

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

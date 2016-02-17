using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative.BuildingBlocks
{
    public interface IVillage
    {
        List<IStar> Stars { get; set; }
        void AddStar(IStar star);
    }
}

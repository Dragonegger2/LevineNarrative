using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative.BuildingBlocks
{
    public interface IStar
    {
        int MacroPassion { get; }
        string Name { get; set; }

        List<IPassion> Passions { get; }
        List<IPassion> ActivePassions { get; }

        void AssignPassions();
    }
}


using System;
using System.Collections.Generic;
using LevineNarrative.BuildingBlocks;

namespace LevineNarrative.Blocks
{
    /// <summary>
    /// Implements IVillage
    /// 
    /// </summary>
    public class BaseVillage : IVillage
    {
        public string VillageName { get; set; }
        public List<IStar> Stars { get; set; }
        public List<IThreshold> VillageThreshold { get; set; }

        public BaseVillage()
        {
            Stars = new List<IStar>();
            VillageThreshold = new List<IThreshold>();
        }

        /// <summary>
        /// Value of the avg passion value of all stars of the a village
        /// </summary>
        public int MacroPassion 
        {
            get
            {
                return calcMacro();
            }
        }

        /// <summary>
        /// Add the current value of all the stars in a village to determine an average
        /// </summary>
        /// <returns>Average of all the macropassion values of each star in village</returns>
        private int calcMacro()
        {
            float avg = 0;

            foreach( IStar star in Stars )
            {
                avg += star.MacroPassion;
            }

            avg /= Stars.Count;

            return (int) avg; // this will truncate the value, should look at better control.
        }

        public override string ToString()
        {
            string str = VillageName + ":\n";

            str += "Macro: " + MacroPassion + "\n"; 

            foreach(var star in Stars)
            {
                str += star.ToString() + "\n";
            }

            foreach(var thresh in VillageThreshold)
            {
                str += thresh + "\n";
            }

            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LevineNarrative.BuildingBlocks;

namespace LevineNarrative.Blocks
{
    /// <summary>
    /// A 
    /// </summary>
    public class BaseStar : IStar
    {
        public BaseStar()
        {
            Passions = new List<IPassion>();
        }

        public BaseStar(List<IPassion> passions, String name)
        {
            Passions = passions;
            Name = name;
        }

        protected int MAX_ACTIVE_PASSIONS = 3;
        protected int MAX_HIDDEN_PASSIONS = 1;

        public string Name { get; set; }
        public List<IPassion> Passions { get; private set; }
        public List<IPassion> ActivePassions { get; private set; }
        public void AssignPassions()
        {
            throw new NotImplementedException();
        }

        public int MacroPassion
        {
            get
            {
                float avg = 0;

                foreach (var passion in Passions)
                {
                    avg += passion.PassionValue;
                }

                avg /= Passions.Count;

                return (int)avg; // this will truncate the value, should look at better control.
            }
        }

        public override string ToString()
        {
            string str = Name + ":\n";

            foreach(var passion in Passions)
            {
                str += passion.ToString();
            }

            return str;
        }

    }
}

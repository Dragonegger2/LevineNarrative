using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LevineNarrative.BuildingBlocks;

namespace LevineNarrative.System
{
    public class ActionListener
    {
        public ActionListener()
        {
            ManagedPassions = new List<IPassion>();
        }

        /// <summary>
        /// Exposes the managed passions to outside users.
        /// </summary>
        public List<IPassion> ManagedPassions { get; private set; }

        /// <summary>
        /// Adds a referenced passion to the list. 
        /// TODO: Need to find out if a list only ever handles references. If that is the case then I do not need the ref keyword.
        /// </summary>
        /// <param name="passion"></param>
        public void AddManagedPassion(IPassion passion)
        {
            ManagedPassions.Add(passion);
        }

        /// <summary>
        /// Always assumes a positive event in favor of the passed passion value. 
        /// Others may react negatively to it.
        /// </summary>
        /// <param name="passion"></param>
        /// <param name="strength"></param>
        public void FireEvent(string passion, int strength)
        {
            var hates = ManagedPassions.FindAll(i => i.Hates.Contains(passion));
            foreach (var iter in hates)
            {
                iter.PassionValue = iter.PassionValue - strength;
            }

            var likes = ManagedPassions.FindAll(i => i.Likes.Contains(passion));
            foreach (var iter in likes)
            {
                iter.PassionValue = iter.PassionValue + strength;
            }
        }
    }
}

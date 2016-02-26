using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

        ///// <summary>
        ///// Always assumes a positive event in favor of the passed passion value. 
        ///// Others may react negatively to it.
        ///// </summary>
        ///// <param name="passion"></param>
        ///// <param name="strength"></param>
        //public void FireEvent(string passion, int strength)
        //{
        //    var hates = ManagedPassions.FindAll(i => i.Hates.Contains(passion));
        //    foreach (var iter in hates)
        //    {
        //        iter.PassionValue = iter.PassionValue - strength;
        //    }

        //    var likes = ManagedPassions.FindAll(i => i.Likes.Contains(passion));
        //    foreach (var iter in likes)
        //    {
        //        iter.PassionValue = iter.PassionValue + strength;
        //    }
        //}

        /// <summary>
        /// Always assumes a positive event in favor of the passed passion value. 
        /// Others may react negatively to it.
        /// </summary>
        /// <param name="passion"></param>
        /// <param name="strength"></param>
        public void FireEvent(List<string> noun, List<string> adj, int strength)
        {
            List<IPassion> positivelyImpacted = new List<IPassion>();
            List<IPassion> negativelyImpacted = new List<IPassion>();

            //Case 1: No adjectives.
            if (noun.Count > 0 && adj.Count == 0)
            {
                //Iterate only on nouns.
                //Find all positive nouns.
                //.Intersect(noun).Any());
   /*             foreach (var passion in ManagedPassions)
                {
                    if(passion.Positives.Any(i => noun.Contains(i.Noun))) { positivelyImpacted.Add(passion);}
                    if(passion.Negatives.Any(i => noun.Contains(i.Noun))) { negativelyImpacted.Add(passion);}
                }*/
                //ManagedPassions.All(i => i.Positives.Where(j => noun.Contains(j.Noun));
                ManagedPassions.All(passion => passion.Positives.All(j => noun.Contains((j.Noun))));
            }

            else if (noun.Count == 0 && adj.Count > 0)
            {

            }

            else
            {
                
            }
        }
    }
}

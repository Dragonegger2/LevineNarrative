using LevineNarrative.BuildingBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative
{
    public interface IPassion
    {
        string PassionName { get; set; }
        float PassionValue { get; set; }

        List<string> Likes { get; set; }
        List<string> Hates { get; set; } 
        
        List<IThreshold> Thresholds { get; }
        List<IThreshold> ThresholdsHit();
    }

    /// <summary>
    /// Not expressive enough to encompass different feelings and hyper focused 
    /// </summary>
    public enum PassionValue
    {
        Elves, Brown
    }

    public class Principles
    {
        //Singular Noun
        public string Noun { get; set; }

        //0-to-many Adjectives
        public List<string> Adjective { get; set;}
    }
}

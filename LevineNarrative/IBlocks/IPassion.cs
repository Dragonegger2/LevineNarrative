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

        List<Principles> Positives { get; set; }
        List<Principles> Negatives { get; set; } 
        
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
        public Principles(string Noun)
        {
            this.Noun = Noun;
            Adjective = new List<string>();
        }

        //TODO: There might be issues if I were to leave the Noun as an empty string. 
        //It could actually match.
        public Principles(List<string> Adjectives)
        {
            this.Adjective = new List<string>();
            this.Adjective = Adjectives;
            this.Noun = null;
        }

        public Principles(string Noun, List<string> Adjective)
        {
            this.Noun = Noun;
            this.Adjective = Adjective;
        }
        //Singular Noun
        public string Noun { get; set; }

        //0-to-many Adjectives
        public List<string> Adjective { get; set;}
    }
}

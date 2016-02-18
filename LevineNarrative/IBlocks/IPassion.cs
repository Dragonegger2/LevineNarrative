﻿using LevineNarrative.BuildingBlocks;
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

        List<PassionValue> Likes { get; set; }
        List<PassionValue> Hates { get; set; } 
        
        List<IThreshold> Thresholds { get; }
        List<IThreshold> ThresholdsHit();
    }

    public enum PassionValue
    {
        Cats, Dogs
    }
}

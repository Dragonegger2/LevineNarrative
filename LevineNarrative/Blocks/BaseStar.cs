﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LevineNarrative.BuildingBlocks;

namespace LevineNarrative.Blocks
{
    public class BaseStar : IStar
    {
        public BaseStar(List<IPassion> passions)
        {
            Passions = passions;
        }

        protected int MAX_ACTIVE_PASSIONS = 3;
        protected int MAX_HIDDEN_PASSIONS = 1;

        public int MacroPassion { get; private set; }
        public string Name { get; set; }
        public List<IPassion> Passions { get; private set; }
        public List<IPassion> ActivePassions { get; private set; }
        public void AssignPassions()
        {
            throw new NotImplementedException();
        }
    }
}
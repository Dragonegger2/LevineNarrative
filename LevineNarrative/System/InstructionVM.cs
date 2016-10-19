using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevineNarrative.System
{
    class InstructionVM
    {
        private enum Instruction
        {
            SET_HEALTH     = 0x00,
            SET_DISPOSTION = 0x01,
            GET_STRING     = 0x02,
            SET_NAME       = 0x03,
            SET_THRESHOLD  = 0x04
        };

        //Empty Constructor
        public InstructionVM() { }


    }
}

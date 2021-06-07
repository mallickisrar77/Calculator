using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCalculator.Interface
{
    public interface IInstructionReader
    {
        public IEnumerable<IInstruction> ReadInstrutionFromFile(string Filename);
       
    }
}

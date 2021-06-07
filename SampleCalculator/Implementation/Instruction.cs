using SampleCalculator.Constants;
using SampleCalculator.Interface;

namespace SampleCalculator.Implementation
{
    public class Instruction : IInstruction
    {
        public Operation InstructionOperation { get; set ; }
        public int InstructionValue { get; set; }
    }
}

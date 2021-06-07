using SampleCalculator.Constants;

namespace SampleCalculator.Interface
{
    public interface IInstruction
    {
        public Operation InstructionOperation { get; set; }
        public int InstructionValue { get; set; }
    }
}

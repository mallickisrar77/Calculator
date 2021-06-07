using SampleCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SampleCalculator.Constants;
using SampleCalculator.Implementation;

namespace SampleCalculator.Service
{
	public class CalculatorService
	{
		
		private static int applyValue = 0;
        private readonly IEnumerable<IInstruction> _instructions;

        public CalculatorService(IEnumerable<IInstruction> instructions)
		{
			_instructions = instructions ?? throw new ArgumentNullException(nameof(instructions));           

		}
		public int Calculate()
		{
			if (_instructions.Any(e => e.InstructionOperation.ToString().Equals(Operation.Apply.ToString(), StringComparison.InvariantCultureIgnoreCase)))
			{
				applyValue = _instructions.Where(e => e.InstructionOperation.ToString().Equals(Operation.Apply.ToString(), StringComparison.InvariantCultureIgnoreCase)).LastOrDefault().InstructionValue;

				Dictionary<Operation, Func<IBinaryOperation>> strategies = new Dictionary<Operation, Func<IBinaryOperation>>()
				{
					{ Operation.Add, () => new AddOperation() },
					{ Operation.Subtract, () => new SubtractOperation() },
					{ Operation.Multiply, () => new MultiplyOperation() },
					{ Operation.Divide, () => new DivideOperation() }
				};

				foreach (var instruction in _instructions.Where(i => i.InstructionOperation.ToString() != Operation.Apply.ToString()))
				{
					IBinaryOperation selectedStrategy = strategies[instruction.InstructionOperation]();
					applyValue = selectedStrategy.Calculate(applyValue, instruction.InstructionValue);
                }
			}
			
			return applyValue;
		}        

	}
}

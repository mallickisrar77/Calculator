using SampleCalculator.Constants;
using SampleCalculator.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SampleCalculator.Implementation
{
    public class InstructionReader : IInstructionReader
    {
        public IEnumerable<IInstruction> ReadInstrutionFromFile(string Filename)
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new ArgumentNullException(nameof(Filename));
            }
            try
            {
                return File.ReadAllLines(Filename)
                            .Where(line => line != "")
                            .Select(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToList()
                            .Select(s => new Instruction()
                            {
                                InstructionOperation = (Operation)Enum.Parse(typeof(Operation), s[0], true),
                                InstructionValue = int.Parse(s[1])
                            }).ToList();
            }
            catch (Exception)
            {
                return null;
            }            
        }       
    }
}

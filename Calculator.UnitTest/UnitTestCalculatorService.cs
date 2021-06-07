using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.Interface;
using System;
using System.Collections.Generic;
using SampleCalculator.Service;
using SampleCalculator.Implementation;
using SampleCalculator.Constants;

namespace Calculator.UnitTest
{
    [TestClass]
    public class UnitTestCalculatorService
    {
        [TestMethod]
        public void CalculatorService_ShouldThrowArgumentException_IfEmpty()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new CalculatorService(null));
        }

        [TestMethod()]
        public void CalculatorService_Shouldreturn_15()
        {
            IList<IInstruction> instructionList = new List<IInstruction>
            {
                new Instruction { InstructionOperation = (Operation)Enum.Parse(typeof(Operation), "Add", true), InstructionValue = 2 },
                new Instruction { InstructionOperation = (Operation)Enum.Parse(typeof(Operation), "Multiply", true), InstructionValue = 3 },
                new Instruction { InstructionOperation = (Operation)Enum.Parse(typeof(Operation), "Apply", true), InstructionValue = 3 }
            };
            var result = new CalculatorService(instructionList).Calculate();
            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void CalculatorService_Shouldreturn_45()
        {
            IList<IInstruction> instructionList = new List<IInstruction>
            {                
                new Instruction { InstructionOperation = (Operation)Enum.Parse(typeof(Operation), "Multiply", true), InstructionValue = 9},
                new Instruction { InstructionOperation = (Operation)Enum.Parse(typeof(Operation), "Apply", true), InstructionValue = 5 }
            };
            var result = new CalculatorService(instructionList).Calculate();
            Assert.AreEqual(45, result);
        }

    }
}

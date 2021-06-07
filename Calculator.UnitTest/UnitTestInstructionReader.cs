using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.Constants;
using SampleCalculator.Implementation;
using SampleCalculator.Interface;
using System;

namespace Calculator.UnitTest
{
    [TestClass]
    public class UnitTestInstructionReader
    {
        [TestMethod]
        public void InstructionReader_ShouldThrowArgumentException_IfEmpty()
        {
            IInstructionReader instructionReader = new InstructionReader();  
            Assert.ThrowsException<ArgumentNullException>(() => instructionReader.ReadInstrutionFromFile(string.Empty));
        }

        [DataTestMethod]            
        public void InstructionReader_ShouldReturnListofInstruction()
        {
            string FileName = InstrutionInputFilePath.Templates;
            IInstructionReader instructionReader = new InstructionReader();
            var resultList =  instructionReader.ReadInstrutionFromFile(FileName);
            Assert.IsNotNull(resultList);
        }
    }
}

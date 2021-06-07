using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalculator.Implementation;
using System;

namespace Calculator.UnitTest
{
    [TestClass]
    public class UnitTestCalculatorOperation
    {
        [DataTestMethod]
        [DataRow(7, 3, 4)]
        [DataRow(8, 2, 6)]       
        public void AddOperation(int result, int num1, int num2)
        {           
            var operation = new AddOperation();
            Assert.AreEqual(result, operation.Calculate(num1, num2));

        }
        [DataTestMethod]
        [DataRow(1, 4, 3)]
        [DataRow(4, 6, 2)]       
        public void SubtractOperation(int result, int num1, int num2)
        {
            var operation = new SubtractOperation();
            Assert.AreEqual(result, operation.Calculate(num1, num2));

        }
        [DataTestMethod]
        [DataRow(16, 4, 4)]
        [DataRow(12, 2, 6)]      
        public void MultiplyOperation(int result, int num1, int num2)
        {
            var operation = new MultiplyOperation();
            Assert.AreEqual(result, operation.Calculate(num1, num2));

        }

        [DataTestMethod]
        [DataRow(0, 3, 4)]
        [DataRow(3, 6, 2)]       
        public void DivideOperation(int result, int num1, int num2)
        {
            var operation = new DivideOperation();
            Assert.AreEqual(result, operation.Calculate(num1, num2));

        }

        [DataTestMethod]
        [DataRow(3, 0)]        
        public void DivideOperationWithDivideByZeroException(int num1, int num2)
        {
            var operation = new DivideOperation();
            //Assert.AreEqual(result, operation.Calculate(num1, num2));
            Assert.ThrowsException<DivideByZeroException>(() => operation.Calculate(num1, num2));

        }     

    }
}

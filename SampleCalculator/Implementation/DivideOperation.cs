using SampleCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCalculator.Implementation
{
    public class DivideOperation : IBinaryOperation
    {
        public int Calculate(int num1, int num2)
        { 
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException();             
            }
        }
    }
}

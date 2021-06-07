using SampleCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCalculator.Implementation
{
    public class MultiplyOperation : IBinaryOperation
    {       
        public int Calculate(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}

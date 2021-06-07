using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SampleCalculator.Constants
{
    public class InstrutionInputFilePath
    {
        public static readonly string App = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static readonly string Templates = Path.Combine(App, @"TestFile\Calculator.txt");
    }
}

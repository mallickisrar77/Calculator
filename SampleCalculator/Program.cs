using Microsoft.Extensions.DependencyInjection;
using SampleCalculator.Constants;
using SampleCalculator.Interface;
using SampleCalculator.Service;
using System;
using System.IO;

namespace SampleCalculator
{
    class Program
    {     
        
        static void Main()
        { 
            string filepath = InstrutionInputFilePath.Templates;

            if (File.Exists(filepath))
            {
                var services = Startup.ConfigureServices();
                var serviceProvider = services.BuildServiceProvider();
                var instructions = serviceProvider.GetService<IInstructionReader>().ReadInstrutionFromFile(filepath);

                if (instructions == null)
                {
                    Console.WriteLine($"Invalid instructions.");
                }
                else
                {
                    foreach (var s in instructions)
                    {
                        Console.WriteLine($"{s.InstructionOperation} {s.InstructionValue}");
                    }

                    CalculatorService calService = new CalculatorService(instructions);
                    Console.WriteLine($"Result: {calService.Calculate()}");
                }
            }

            Console.ReadKey();

        }
    }
}

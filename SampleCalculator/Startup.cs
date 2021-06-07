using Microsoft.Extensions.DependencyInjection;
using SampleCalculator.Implementation;
using SampleCalculator.Interface;

namespace SampleCalculator
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
            var serviceCollection = new ServiceCollection()                           
                    .AddSingleton<IInstructionReader, InstructionReader>()
                    .AddSingleton<IInstruction, Instruction>();
            return serviceCollection;
        }
    }
}

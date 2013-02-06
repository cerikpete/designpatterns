using System;

namespace DuckLibrary.BarnAutomation
{
    public class LightsOffCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Turning off the Lights!");
        }
    }
}
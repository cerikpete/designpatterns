using System;

namespace DuckLibrary.BarnAutomation
{
    public class OpenTheWindowsCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Windows are now open.");
        }
    }
}
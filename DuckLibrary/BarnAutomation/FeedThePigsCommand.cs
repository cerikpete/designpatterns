using System;

namespace DuckLibrary.BarnAutomation
{
    public class FeedThePigsCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Pigs are fed.");

        }
    }
}
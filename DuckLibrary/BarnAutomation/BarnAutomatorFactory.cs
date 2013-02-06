using System;

namespace DuckLibrary.BarnAutomation
{
    public class BarnAutomatorFactory : IBarnAutomatorFactory
    {
        public IBarnAutomator GetMeTheBarnAutomator3000Deluxe()
        {
            var automator = new BarnAutomator3000Deluxe();
            
            // Setting morning commands
            automator.SetMorningCommand(new LightsOnCommand());
            automator.SetMorningCommand(new FeedTheDucksCommand());
            automator.SetMorningCommand(new MuckTheStallsCommand());

            // Setting afternoon commands
            automator.SetAfternoonCommand(new OpenTheWindowsCommand());
            automator.SetAfternoonCommand(new FeedThePigsCommand());

            // Setting afternoon commands
            automator.SetEveningCommand(new CloseWindowsCommand());
            automator.SetEveningCommand(new FeedTheHorsesCommand());
            automator.SetEveningCommand(new LightsOffCommand());

            return automator;
        }
    }
}
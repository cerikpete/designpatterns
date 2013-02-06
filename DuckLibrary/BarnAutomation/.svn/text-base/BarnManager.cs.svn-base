using System;

namespace DuckLibrary.BarnAutomation
{
    public class BarnManager
    {
        private readonly IBarnAutomatorFactory automatorFactory;

        public BarnManager(IBarnAutomatorFactory automatorFactory)
        {
            this.automatorFactory = automatorFactory;
        }


        public void ManageTheBarn()
        {
            var automator = automatorFactory.GetMeTheBarnAutomator3000Deluxe();

            Console.WriteLine("--Performing Morning Jobs--");
            automator.PerformMorningJobs();
            Console.WriteLine("--Performing Afternoon Jobs--");
            automator.PerformAfternoonJobs();
            Console.WriteLine("--Performing Evening Jobs--");
            automator.PerformEveningJobs();
        }

    }
}
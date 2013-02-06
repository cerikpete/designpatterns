namespace DuckLibrary.BarnAutomation
{
    public interface IBarnAutomator
    {
        void PerformMorningJobs();
        void PerformAfternoonJobs();
        void PerformEveningJobs();
    }
}
using System.Collections.Generic;

namespace DuckLibrary.BarnAutomation
{
    public class BarnAutomator3000Deluxe : IBarnAutomator
    {
        private List<ICommand> morningCommands = new List<ICommand>();
        private List<ICommand> afternoonCommands = new List<ICommand>();
        private List<ICommand> eveningCommands = new List<ICommand>();

        public void SetMorningCommand(ICommand command)
        {
            morningCommands.Add(command);
        }

        public void SetAfternoonCommand(ICommand command)
        {
            afternoonCommands.Add(command); 
        }

        public void SetEveningCommand(ICommand command)
        {
            eveningCommands.Add(command);
        }

        public void PerformMorningJobs()
        {
            foreach (var command in morningCommands)
            {
                command.Execute();
            }
        }

        public void PerformAfternoonJobs()
        {
            foreach (var command in afternoonCommands)
            {
                command.Execute();
            }
        }

        public void PerformEveningJobs()
        {
            foreach (var command in eveningCommands)
            {
                command.Execute();
            }
        }
    }
}
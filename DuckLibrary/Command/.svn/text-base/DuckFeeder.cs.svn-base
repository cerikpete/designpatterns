using System.Collections.Generic;

namespace DuckLibrary.Command
{
    /// <summary>
    /// Invoker object for the command pattern
    /// </summary>
    public class DuckFeeder
    {
        private List<ICommand> commands = new List<ICommand>();

        public void SetCommand(ICommand command)
        {
            commands.Add(command);
        }

        public string ExecuteCommand()
        {
            return commands[commands.Count - 1].Execute();
        }

        public string Undo()
        {
            // Undo last command, then remove it
            string text = "Undoing command: " + commands[commands.Count - 1].GetType();
            commands.Remove(commands[commands.Count - 1]);
            return text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Input;

namespace Delivery.Pattern.CommandPattern
{
    public class Invoker
    {
        private List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }

            commands.Clear();
        }

        public void UndoLastCommand()
        {
            if (commands.Count > 0)
            {
                var last = commands[commands.Count - 1];
                last.Undo();
                commands.RemoveAt(commands.Count - 1);
            }
        }
    }
}
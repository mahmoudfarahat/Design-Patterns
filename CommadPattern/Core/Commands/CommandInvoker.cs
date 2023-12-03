using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadPattern.Core.Commands
{
    internal class CommandInvoker
    {
        private List<ICommand> _commands = new();

        private Stack<ICommand> _executedCommands = new();
        private Stack<ICommand> _undoneCommands = new();

        public void AddCommand(ICommand command) 
        { 
            _commands.Add(command);
        }

        public void ExcludeCommands()
        {
            foreach (var command in _commands)
            {
                ExecuteCommand(command);
            }

            ClearCommnad();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _executedCommands.Push(command);
        }

        public void Undo()
        {
            var command = _executedCommands.Pop();
            command.Undo();
            _undoneCommands.Push(command);
        }
        public void Redo ()
        {
            var command = _undoneCommands.Pop();
            ExecuteCommand(command);
        }
        public void ClearCommnad()
        {
            _commands.Clear();
        }

        internal IEnumerable<ICommand> GetCommands()
        {
            return _commands.AsReadOnly();
        }


    }
}

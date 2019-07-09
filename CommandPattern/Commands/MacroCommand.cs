using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            for (var i = _commands.Length - 1; i > 0; i--)
            {
                _commands[i].Undo();
            }
        }
    }
}

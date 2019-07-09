using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern.Remote
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            var noCommand = new NoCommand();
            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append(
                    $"[slot {i}] {_onCommands[i].GetType().Name}" +
                    $"\t\t{_offCommands[i].GetType().Name}\n");
            }

            stringBuilder.Append($"[Undo] {_undoCommand.GetType().Name}\n");
            return stringBuilder.ToString();
        }
    }
}
